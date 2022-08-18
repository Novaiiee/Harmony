using AutoMapper;
using Harmony.Application.Contracts;
using Harmony.Application.Contracts.Requests;
using Harmony.Application.Contracts.Responses;
using Harmony.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Harmony.Application.Services.Reflection;

public class ReflectionService : IReflectionService
{
    private readonly IDataContext context;
    private readonly IMapper mapper;

    public ReflectionService(IDataContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    public async Task<Response<int>> CreateReflectionAsync(User user, CreateReflectionRequest model)
    {
        var activityRows = context.Activities.Where(x => model.Activities.Contains(x.Name)).ToList();
        var feelingsRows = context.Feelings.Where(x => model.Feelings.Contains(x.Name)).ToList();
        var mood = context.Moods.Where(x => x.Name == model.Mood).FirstOrDefault()!;

        var newEntry = new ReflectionEntry
        {
            MoodId = mood.Id,
            UserId = user.Id,
            Description = model.Description,
            Title = model.Title,
            Activities = activityRows,
            Feelings = feelingsRows
        };

        foreach (var activity in activityRows)
        {
            activity.Reflections.Add(newEntry);
            context.Activities.Update(activity);
        }

        foreach (var feeling in feelingsRows)
        {
            feeling.Reflections.Add(newEntry);
            context.Feelings.Update(feeling);
        }

        mood.Reflections.Add(newEntry);

        await context.Reflections.AddAsync(newEntry);
        await context.SaveChangesAsync();

        return new Response<int>
        {
            Data = 0,
            StatusCode = 201,
            Message = "Successfully created the reflection",
        };
    }

    public async Task<Response<int>> DeleteReflectionAsync(User user, string id)
    {
        if (!context.Reflections.Any())
        {
            return await Task.FromResult(new Response<int>
            {
                Data = 0,
                Message = "No Entries found but no error",
                StatusCode = 200,
            });
        }
        var doc = await context.Reflections.Where(x => x.Id == id).FirstOrDefaultAsync();

        if (doc is null)
        {
            return await Task.FromResult(new Response<int>
            {
                Data = 1,
                Message = "Reflection not found",
                StatusCode = 404,
            });
        }

        context.Reflections.Remove(doc);
        await context.SaveChangesAsync();

        return await Task.FromResult(new Response<int>
        {
            Data = 0,
            Message = "Successfully deleted the reflection",
            StatusCode = 200,
        });
    }

    public async Task<Response<List<GetReflectionsResponse>>> GetAllEntriesAsync(string userId)
    {
        if (!context.Reflections.Any())
        {
            return await Task.FromResult(new Response<List<GetReflectionsResponse>>
            {
                Data = new List<GetReflectionsResponse>(),
                Message = "No Entries found but no error",
                StatusCode = 200,
            });
        }

        var entries = context.Reflections
            .Where(x => x.UserId == userId)
            .Include(x => x.Mood)
            .Include(x => x.Feelings)
            .Include(x => x.Activities)
            .Select(x => mapper.Map<GetReflectionsResponse>(x))
            .ToList();

        return await Task.FromResult(new Response<List<GetReflectionsResponse>>
        {
            Data = entries,
            Message = "Successfully queried all entries",
            StatusCode = 200,
        });
    }
}