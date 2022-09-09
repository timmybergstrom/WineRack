using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace WineRack.Domain;

public static class DomainServicesRegistration 
{
	public static IServiceCollection AddDomainServices(this IServiceCollection services, IConfiguration configuration)
	{
        services.AddDbContext<WineRackContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("WineRackDb"));
        });
        return services;
	}
}
