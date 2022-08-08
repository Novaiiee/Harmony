using Harmony.Application;
using Harmony.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NodaTime;

namespace Harmony.Infrastructure;

public class DataContext : IdentityDbContext<User>, IDataContext
{
    public DbSet<Feeling> Feelings { get; set; } = null!;
    public DbSet<JournalEntry> JournalEntries { get; set; } = null!;
    public DbSet<Activity> Activities { get; set; } = null!;
    public DbSet<Mood> Moods { get; set; } = null!;

    private IConfiguration Config { get; init; }

    public DataContext(IConfiguration config, DbContextOptions options) : base(options)
    {
        Config = config;
    }

    public async Task SaveChangesAsync() => await base.SaveChangesAsync();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            options.UseNpgsql(Config.GetConnectionString("Database"), x => x.UseNodaTime());
            options.EnableSensitiveDataLogging();
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //UUID
        builder.Entity<Activity>()
            .Property(b => b.Id)
            .HasDefaultValue(new Guid().ToString());

        builder.Entity<Feeling>()
            .Property(b => b.Id)
            .HasDefaultValue(new Guid().ToString());

        builder.Entity<JournalEntry>()
            .Property(b => b.Id)
            .HasDefaultValue(new Guid().ToString());

        builder.Entity<Mood>()
            .Property(b => b.Id)
            .HasDefaultValue(new Guid().ToString());

        //Created At
        builder.Entity<Activity>()
            .Property(b => b.CreatedAt)
            .HasDefaultValue(new Instant());

        builder.Entity<Feeling>()
            .Property(b => b.CreatedAt)
            .HasDefaultValue(new Instant());

        builder.Entity<JournalEntry>()
            .Property(b => b.CreatedAt)
            .HasDefaultValue(new Instant());

        builder.Entity<Mood>()
            .Property(b => b.CreatedAt)
            .HasDefaultValue(new Instant());

        //Updated At
        builder.Entity<Activity>()
            .Property(b => b.UpdatedAt)
            .HasDefaultValue(new Instant());

        builder.Entity<Feeling>()
            .Property(b => b.UpdatedAt)
            .HasDefaultValue(new Instant());

        builder.Entity<JournalEntry>()
            .Property(b => b.UpdatedAt)
            .HasDefaultValue(new Instant());

        builder.Entity<Mood>()
            .Property(b => b.UpdatedAt)
            .HasDefaultValue(new Instant());

        Seed.Create(builder);
    }
}
