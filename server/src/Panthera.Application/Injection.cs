using Microsoft.Extensions.DependencyInjection;
using Panthera.Application.Services.Auth;

namespace Panthera.Application;

public static class Injection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        return services;
    }
}