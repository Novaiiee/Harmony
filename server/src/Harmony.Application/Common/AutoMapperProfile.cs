using AutoMapper;
using Harmony.Application.Contracts.Requests;
using Harmony.Application.Contracts.Responses;
using Harmony.Domain.Entities;

namespace Harmony.Application.Common;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ReflectionEntry, GetReflectionsResponse>()
            .ForMember(x => x.Activities, x => x.MapFrom(entry => entry.Activities.Select(x => x.Name)))
            .ForMember(x => x.Feelings, x => x.MapFrom(entry => entry.Feelings.Select(x => x.Name)))
            .ForMember(x => x.Mood, x => x.MapFrom(entry => entry.Mood.Name))
            .ForMember(x => x.CreatedAt, x => x.MapFrom(entry => entry.CreatedAt.ToString().Split('T', StringSplitOptions.TrimEntries).First()));
    }
}