using Panthera.Domain.Entities;

namespace Panthera.Application.Interfaces;

public interface IJwtGenerator
{
    string GenerateToken(User user);
}