using NodaTime;

namespace Harmony.Domain.Entities;

public class BaseEntity
{
    public string Id { get; set; } = null!;
    public Instant CreatedAt { get; set; }
    public Instant UpdatedAt { get; set; }
}