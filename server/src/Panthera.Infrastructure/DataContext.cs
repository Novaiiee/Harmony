using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Panthera.Domain.Entities;

namespace Panthera.Infrastructure;

public class DataContext : IdentityDbContext<User>
{
    private IConfiguration Config { get; init; }

    public DataContext(IConfiguration config, DbContextOptions options) : base(options)
    {
        Config = config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            options.UseNpgsql(Config.GetConnectionString("Database"));
        }
    }

    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //     base.OnModelCreating(builder);
    // }
}
