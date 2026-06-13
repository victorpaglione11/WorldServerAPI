using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorldServer.Infrastructure.Persistence;

namespace WorldServer.Infrastructure.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection
            AddInfrastructure(
                this IServiceCollection services,
                IConfiguration configuration)
        {
            services.AddDbContext<WorldDbContext>(
                options =>
                options.UseNpgsql(
                    configuration
                    .GetConnectionString(
                        "DefaultConnection"
                    )
                )
            );

            return services;
        }
    }
}