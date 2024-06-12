using NortWind.BlazingPizza.Frontend.ViewModels.ConfigurePizzaDialog;

namespace NortWind.BlazingPizza.Frontend.ViewModels
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {

            services.AddScoped<GetSpecialViewModel>();
            services.AddScoped<ConfigurePizzaDialogViewModel>();
            return services;
        }
    }
}
