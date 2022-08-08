using Harmony.Application.Contracts;
using Harmony.Application.Contracts.Requests;
using Harmony.Domain.Entities;

namespace Harmony.Application.Services.Journal;

public interface IJournalService
{
    public Task<Response<List<JournalEntry>>> GetAllEntriesAsync(string userId);
    public Task<Response<int>> CreateJournalAsync(User user, CreateJournalRequest model);
}