using Microsoft.Extensions.DependencyInjection;
using Spellcasters.Application.Services.Authentication;

namespace Spellcasters.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
