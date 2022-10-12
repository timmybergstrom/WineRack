using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WineRack.Repository;

public static class RepositoryServicesRegistration
{
	public static IServiceCollection AddRepositoryServices(this IServiceCollection services, IConfiguration configuration)
	{

		services.AddScoped<IBaseServices, BaseRepository>();
		return services;
	}
}
