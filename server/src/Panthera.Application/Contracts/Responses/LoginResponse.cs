using Panthera.Domain.Entities;

namespace Panthera.Application.Contracts.Responses;

public record LoginResponse(User User, string Token);