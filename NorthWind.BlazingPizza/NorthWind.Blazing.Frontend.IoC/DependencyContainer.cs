using Microsoft.Extensions.Options;
using NorthWind.Blazing.Frontend.BusinessObjects;
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


            Uri WebApiUri = new Uri(BlazingPizzaOptions.WebApiBaseAddress);
            services.AddModels(
                httpClient => httpClient.BaseAddress = WebApiUri,
                null,
                httpClient => httpClient.BaseAddress = WebApiUri,
                null
                );

            services.AddViewModels();

            services.AddSingleton(Options.Create(BlazingPizzaOptions));

            services.AddBusinessObjectsServices();

            return services;
        }
    }
}

