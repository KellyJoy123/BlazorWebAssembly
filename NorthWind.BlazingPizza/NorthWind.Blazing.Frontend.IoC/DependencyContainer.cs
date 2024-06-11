using Microsoft.Extensions.Options;
using NorthWind.Blazing.Frontend.BusinessObjects.Options;

namespace NorthWind.BlazingPizza.Frontend.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddFrontendServices(
            this IServiceCollection services,
            Action<BlazingPizzaOptions> configureBlazingPizzaOptions)
        {
            BlazingPizzaOptions BlazingPizzaOptions = new();
            configureBlazingPizzaOptions(BlazingPizzaOptions);

            services.AddModels(
                httpClient => httpClient.BaseAddress =
                new Uri(BlazingPizzaOptions.WebApiBaseAddress),
                null);

            services.AddViewModels();

            services.AddSingleton(Options.Create(BlazingPizzaOptions));

            return services;
        }
    }
}
