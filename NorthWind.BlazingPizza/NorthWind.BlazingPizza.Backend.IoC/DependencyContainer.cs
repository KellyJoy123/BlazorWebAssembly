using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Backend.Presenters;
using NorthWind.BlazingPizza.Backend.Repositories;
using NorthWind.BlazingPizza.Backend.UseCases;
using NorthWind.BlazingPizza.EFCore.DataSources;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;

namespace NorthWind.BlazingPizza.Backend.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBlazingPizzaServices(
            this IServiceCollection services,
            Action<DBOptions> configureDBOptions,
            Action<BlazingPizzaOptions> configureBlazingPizzaOptions)
        {
            services.AddUseCasesServices()
                .AddRepositories()
                .AddDataSources(configureDBOptions)
                .AddPresenters();

            services.Configure(configureBlazingPizzaOptions);
            return services;
        }
    }
}
