using Harmony.Application.Contracts.Requests;
using Harmony.Application.Services.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Canine.Controllers;

[Route("auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService authService;

    public AuthController(IAuthService _authService)
    {
        authService = _authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync([FromBody] AuthRequest model)
    {
        var result = await authService.RegisterAsync(model);
        return StatusCode(result.StatusCode, result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromBody] AuthRequest model)
    {
        var result = await authService.LoginAsync(model);
        return StatusCode(result.StatusCode, result);
    }

    [Authorize]
    [HttpGet("jwt")]
    public string Protected()
    {
        return "This works";
    }
}