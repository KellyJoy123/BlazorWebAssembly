using NortWind.BlazingPizza.Frontend.ViewModels.Checkout;
using NortWind.BlazingPizza.Frontend.ViewModels.ConfigurePizzaDialog;
using NortWind.BlazingPizza.Frontend.ViewModels.Index;
using NortWind.BlazingPizza.Frontend.ViewModels.Orders;

namespace NortWind.BlazingPizza.Frontend.ViewModels
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {

            services.AddScoped<GetSpecialViewModel>();
            services.AddScoped<ConfigurePizzaDialogViewModel>();
            services.AddScoped<IndexViewModel>();
            services.AddScoped<ChecjoutViewModel>();
            services.AddScoped<OrdersViewModel>();
            return services;
        }
    }
}
