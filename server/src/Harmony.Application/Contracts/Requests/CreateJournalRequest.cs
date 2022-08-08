using System.ComponentModel.DataAnnotations;

namespace Harmony.Application.Contracts.Requests;

public class CreateJournalRequest
{
    [Required]
    public List<string> Activities { get; set; } = null!;

    [Required]
    public List<string> Feelings { get; set; } = null!;

    [Required]
    public string Mood { get; set; } = null!;

    [Required]
    public string Title { get; set; } = null!;

    [Required]
    public string Description { get; set; } = null!;

    [Required]
    public string Date { get; set; } = null!;
}