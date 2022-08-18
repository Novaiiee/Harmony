using Harmony.Application.Services.Auth;
using Harmony.Application.Services.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Harmony.Application;

public static class Injection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IReflectionService, ReflectionService>();
        return services;
    }
}