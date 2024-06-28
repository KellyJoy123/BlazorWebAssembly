using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Backend.Repositories.Repositories;


namespace NorthWind.BlazingPizza.Backend.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsRepository, GetSpecialsReporsitory>();
            services.AddScoped<IGetToppingsRepository, GetToppingsRepository>();
            services.AddScoped<IPlaceOrderRepository, PlaceOrderRepository>();
            services.AddScoped<IGetOrdersRepository, GetOrdersRepository>();

            return services;
        }
    }
}
