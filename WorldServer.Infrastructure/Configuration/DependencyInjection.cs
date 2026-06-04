using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorldServer.Domain.Interfaces;
using WorldServer.Infrastructure.Persistence;
using WorldServer.Infrastructure.Repositories;

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

            services.AddScoped<
                IObjectRepository,
                ObjectRepository>();


            return services;
        }
    }
}