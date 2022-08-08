
namespace Harmony.Domain.Entities;

public class Mood : BaseEntity
{
    public string Name { get; set; } = null!;
    public List<JournalEntry> JournalEntries { get; set; } = null!;
}