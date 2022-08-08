using Harmony.Application.Contracts;
using Harmony.Application.Contracts.Requests;
using Harmony.Application.Services.Auth;
using Harmony.Domain.Entities;

namespace Harmony.Application.Services.Journal;

public class JournalService : IJournalService
{
    private readonly IDataContext context;

    public JournalService(IDataContext context)
    {
        this.context = context;
    }

    public async Task<Response<int>> CreateJournalAsync(User user, CreateJournalRequest model)
    {
        var activityRows = context.Activities.Where(x => model.Activities.Contains(x.Name)).ToList();
        var feelingsRows = context.Feelings.Where(x => model.Feelings.Contains(x.Name)).ToList();
        var mood = context.Moods.Where(x => x.Name == model.Mood).FirstOrDefault()!;

        var newEntry = new JournalEntry
        {
            Activities = activityRows,
            Feelings = feelingsRows,
            Mood = mood,
            MoodId = mood.Id,
            User = user,
            UserId = user.Id,
            Description = model.Description,
            Title = model.Title,
        };

        await context.SaveChangesAsync();

        return new Response<int>
        {
            Data = 0,
            StatusCode = 201,
            Message = "Successfully created the journal entry",
        };
    }

    public async Task<Response<List<JournalEntry>>> GetAllEntriesAsync(string userId)
    {
        if (!context.JournalEntries.Any())
        {
            return await Task.FromResult(new Response<List<JournalEntry>>
            {
                Data = new List<JournalEntry>(),
                Message = "Successfully queried all entries",
                StatusCode = 200,
            });
        }

        var entries = context.JournalEntries.Where(x => x.UserId == userId).ToList();

        return await Task.FromResult(new Response<List<JournalEntry>>
        {
            Data = entries,
            Message = "Successfully queried all entries",
            StatusCode = 200,
        });
    }
}