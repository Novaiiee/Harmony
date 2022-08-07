using Harmony.Domain.Entities;

namespace Harmony.Application.Interfaces;

public interface IJwtGenerator
{
    string GenerateToken(User user);
}