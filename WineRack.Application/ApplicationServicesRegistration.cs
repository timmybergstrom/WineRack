using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace WineRack.Application;

public static class ApplicationServicesRegistration 
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}
