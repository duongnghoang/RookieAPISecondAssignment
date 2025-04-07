using Microsoft.Extensions.DependencyInjection;
using PersonAPI.Application.Interfaces.Repositories;
using PersonAPI.Infrastructure.Repositories;

namespace PersonAPI.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IPersonRepository, PersonRepository>();

        return services;
    }
}