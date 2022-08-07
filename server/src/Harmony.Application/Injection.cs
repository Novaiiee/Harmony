using Harmony.Application.Services.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace Harmony.Application;

public static class Injection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        return services;
    }
}