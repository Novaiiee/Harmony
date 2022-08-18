
using System.Text.Json.Serialization;

namespace Harmony.Domain.Entities;

public class Feeling : BaseEntity
{
    public string Name { get; set; } = null!;

    [JsonIgnore]
    public List<ReflectionEntry> Reflections { get; set; } = null!;
}