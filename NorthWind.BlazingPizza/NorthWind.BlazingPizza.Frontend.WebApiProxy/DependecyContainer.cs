using NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.Checkout;
using NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Frontend.WebApiProxy.Checkout;
using NorthWind.BlazingPizza.Frontend.WebApiProxy.Common;
using NorthWind.BlazingPizza.Frontend.WebApiProxy.GetToppings;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxy
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddModels(
            this IServiceCollection services,
            HttpClientConfigurator getSpecialModelConfigurator,
            HttpClientConfigurator getToppingsModelConfigurator,
            HttpClientConfigurator checkoutModelConfigurator)
        {
            services
                .AddHttpClient<IGetSpecialModel, GetSpecialModel>(getSpecialModelConfigurator)
                .AddHttpClient<IGetToppingsModel, GetToppingsModel>(getToppingsModelConfigurator)
                .AddHttpClient<ICheckoutModel, CheckoutModel>(checkoutModelConfigurator);


            return services;
        }
        static IServiceCollection AddHttpClient<TClient, TImplementation>(
            this IServiceCollection services,
            HttpClientConfigurator configurator)
            where TClient : class where TImplementation : class, TClient
        {
            var Builder = services.AddHttpClient<TClient, TImplementation>(
                configurator.ConfigureHttpClient);

            configurator.ConfigureNamedHttpClient?.Invoke(Builder);


            return services;
        }
    }
}
