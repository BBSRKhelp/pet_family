using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PetFamily.Application.Commands.Volunteer.Create;

namespace PetFamily.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<VolunteerCreateHandler>();
        
        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);
        
        return services;
    }
}