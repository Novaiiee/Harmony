using System.Security.Claims;
using Panthera.Application.Contracts;
using Panthera.Application.Contracts.Requests;
using Panthera.Application.Contracts.Responses;
using Panthera.Domain.Entities;

namespace Panthera.Application.Services.Auth;

public interface IAuthService
{
    Task<IdentityResponse<int>> RegisterAsync(AuthRequest model);
    Task<IdentityResponse<LoginResponse>> LoginAsync(AuthRequest model);
    Task<User> GetUserAsync(ClaimsPrincipal principal);
}