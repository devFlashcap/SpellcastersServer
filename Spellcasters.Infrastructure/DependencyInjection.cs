using Microsoft.Extensions.DependencyInjection;
using Spellcasters.Application.Common.Interfaces.Authentication;
using Spellcasters.Infrastructure.Authentication;

namespace Spellcasters.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}
