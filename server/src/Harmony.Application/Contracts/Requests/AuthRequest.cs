using System.ComponentModel.DataAnnotations;

namespace Harmony.Application.Contracts.Requests;

public class AuthRequest
{
    [Required]
    public string Email { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;
}