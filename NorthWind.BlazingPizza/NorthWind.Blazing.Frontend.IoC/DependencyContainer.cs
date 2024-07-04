using Microsoft.Extensions.Options;
using NorthWind.Blazing.Frontend.BusinessObjects;
using NorthWind.Blazing.Frontend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Frontend.WebApiProxy.Common;

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

            services.AddModels(BlazingPizzaOptions);

            services.AddViewModels();

            services.AddSingleton(Options.Create(BlazingPizzaOptions));

            services.AddBusinessObjectsServices();

            return services;
        }

        static IServiceCollection AddModels(this IServiceCollection services,
            BlazingPizzaOptions options)
        {
            Uri WebApiUri = new Uri(options.WebApiBaseAddress);
            var Configurator = new HttpClientConfigurator(
                httpClient => httpClient.BaseAddress = WebApiUri,
                null);

            services.AddModels(
                Configurator, 
                Configurator, 
                Configurator, 
                Configurator
            );

            return services;
        }
    }
}

