
using System.Text.Json.Serialization;

namespace Harmony.Domain.Entities;

public class ReflectionEntry : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;

    public Mood Mood { get; set; } = null!;
    public string MoodId { get; set; } = null!;

    public List<Activity> Activities { get; set; } = null!;
    public List<Feeling> Feelings { get; set; } = null!;

    [JsonIgnore]
    public User User { get; set; } = null!;
    public string UserId { get; set; } = null!;
}