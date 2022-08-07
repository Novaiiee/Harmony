using Harmony.Domain.Entities;

namespace Harmony.Application.Contracts.Responses;

public record LoginResponse(User User, string Token);