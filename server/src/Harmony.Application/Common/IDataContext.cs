using Harmony.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Harmony.Application;

public interface IDataContext
{
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Feeling> Feelings { get; set; }
    public DbSet<JournalEntry> JournalEntries { get; set; }
    public DbSet<Mood> Moods { get; set; }

    public Task SaveChangesAsync();
}