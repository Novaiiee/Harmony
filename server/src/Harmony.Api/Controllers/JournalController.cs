using System.Security.Claims;
using Harmony.Application.Contracts.Requests;
using Harmony.Application.Services.Auth;
using Harmony.Application.Services.Journal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Canine.Controllers;

[Route("journals"), ApiController, Authorize]
public class JournalController : ControllerBase
{
    private readonly IJournalService journalService;
    private readonly IAuthService authService;

    public JournalController(IJournalService journalService, IAuthService authService)
    {
        this.journalService = journalService;
        this.authService = authService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllJournalsAsync()
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)!.Value;
        var result = await journalService.GetAllEntriesAsync(userId);

        return StatusCode(result.StatusCode, result);
    }

    [HttpGet]
    public async Task<IActionResult> CreateJournalAsync([FromBody] CreateJournalRequest model)
    {
        var user = await authService.GetUserAsync(HttpContext.User);
        var result = await journalService.CreateJournalAsync(user, model);

        return StatusCode(result.StatusCode, result);
    }
}