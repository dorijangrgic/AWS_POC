using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleMinimalApi.DataAccess;

public static class DependencyInjection
{
	public static IServiceCollection AddDataAccess(this IServiceCollection services)
	{
		var connectionString = services.BuildServiceProvider().GetRequiredService<IConfiguration>()
			.GetConnectionString("prodia-db");

		services.AddDbContext<ProdiaDbContext>(options => options.UseNpgsql(connectionString));

		return services;
	}
}