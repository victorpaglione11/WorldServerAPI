using Microsoft.Extensions.DependencyInjection;
using WorldServer.Application.Services;

namespace WorldServer.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection
            AddApplication(
                this IServiceCollection services)
        {
            services.AddScoped<ObjectService>();

            return services;
        }
    }
}