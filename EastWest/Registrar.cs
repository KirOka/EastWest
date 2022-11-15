using BusinessLogic.Services.Abstractions;
using BusinessLogic.Services.Implementations;
using DataAccess.Repositories.Abstractions;
using DataAccess.Repositories.Implementations;
using System.Numerics;

namespace EastWest
{
    public static class Registrar
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .InstallServices()
                .InstallRepositories();
        }

        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IOrderService, OrderService>()
                .AddTransient<IPositionService, PositionService>();
            return serviceCollection;
        }

        private static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IOrdersRepository, OrdersRepository>()
                .AddTransient<IPositionsRepository, PositionsRepository>();
            return serviceCollection;
        }
    }
}
