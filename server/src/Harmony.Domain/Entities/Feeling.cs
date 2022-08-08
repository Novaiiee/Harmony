
namespace Harmony.Domain.Entities;

public class Feeling : BaseEntity
{
    public string Name { get; set; } = null!;
    public List<JournalEntry> JournalEntries { get; set; } = null!;
}