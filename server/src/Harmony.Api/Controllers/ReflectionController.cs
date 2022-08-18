using System.Security.Claims;
using Harmony.Application.Contracts.Requests;
using Harmony.Application.Services.Auth;
using Harmony.Application.Services.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Harmony.Api.Controllers;

[Route("reflections"), ApiController, Authorize]
public class ReflectionController : ControllerBase
{
    private readonly IReflectionService reflectionService;
    private readonly IAuthService authService;

    public ReflectionController(IReflectionService reflectionService, IAuthService authService)
    {
        this.reflectionService = reflectionService;
        this.authService = authService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllReflectionsAsync()
    {
        string userId = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)!.Value;
        var result = await reflectionService.GetAllEntriesAsync(userId);

        return StatusCode(result.StatusCode, result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateReflectionAsync([FromBody] CreateReflectionRequest model)
    {
        var user = await authService.GetUserAsync(HttpContext.User);
        var result = await reflectionService.CreateReflectionAsync(user, model);

        return StatusCode(result.StatusCode, result);
    }
}
