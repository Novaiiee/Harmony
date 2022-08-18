using Harmony.Application.Contracts;
using Harmony.Application.Contracts.Requests;
using Harmony.Application.Contracts.Responses;
using Harmony.Domain.Entities;

namespace Harmony.Application.Services.Reflection;

public interface IReflectionService
{
    public Task<Response<List<GetReflectionsResponse>>> GetAllEntriesAsync(string userId);
    public Task<Response<string>> CreateReflectionAsync(User user, CreateReflectionRequest model);
    public Task<Response<string>> DeleteReflectionAsync(User user, string id);
}