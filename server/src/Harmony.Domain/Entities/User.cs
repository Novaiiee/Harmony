using Microsoft.AspNetCore.Identity;

namespace Harmony.Domain.Entities;

public class User : IdentityUser
{
    public List<ReflectionEntry> Reflections { get; set; } = null!;
}