using Microsoft.Extensions.DependencyInjection;
using PersonAPI.Application.Interfaces.Persons;
using PersonAPI.Application.UseCases.Persons.AddPersonUseCases;

namespace PersonAPI.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAddPersonUseCase, AddPersonUseCase>();

        return services;
    }
}