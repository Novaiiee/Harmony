using System.Security.Claims;
using Harmony.Application.Contracts;
using Harmony.Application.Contracts.Requests;
using Harmony.Application.Contracts.Responses;
using Harmony.Domain.Entities;

namespace Harmony.Application.Services.Auth;

public interface IAuthService
{
    Task<IdentityResponse<string>> RegisterAsync(AuthRequest model);
    Task<IdentityResponse<LoginResponse>> LoginAsync(AuthRequest model);
    Task<User> GetUserAsync(ClaimsPrincipal principal);
}
