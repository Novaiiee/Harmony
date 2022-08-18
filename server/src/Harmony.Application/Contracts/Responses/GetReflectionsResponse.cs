namespace Harmony.Application.Contracts.Responses;

public class GetReflectionsResponse
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Mood { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public string CreatedAt { get; set; } = null!;

    public List<string> Activities { get; set; } = null!;
    public List<string> Feelings { get; set; } = null!;
}