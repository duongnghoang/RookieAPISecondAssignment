using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PersonAPI.Application.Interfaces.Persons;
using PersonAPI.Application.Services.Persons.AddPersonServices;
using PersonAPI.Application.Services.Persons.DeletePersonServices;
using PersonAPI.Application.Services.Persons.FilterPersonServices;
using PersonAPI.Application.Services.Persons.UpdatePersonServices;
using System.Reflection;
using FluentValidation.AspNetCore;

namespace PersonAPI.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddFluentValidationAutoValidation();

        services.AddScoped<IAddPersonService, AddPersonService>();
        services.AddScoped<IUpdatePersonService, UpdatePersonService>();
        services.AddScoped<IDeletePersonService, DeletePersonService>();
        services.AddScoped<IFilterPersonService, FilterPersonService>();

        return services;
    }
}