using NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.Checkout;
using NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Frontend.WebApiProxy.Checkout;
using NorthWind.BlazingPizza.Frontend.WebApiProxy.GetToppings;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxy
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddModels(
            this IServiceCollection services,
            Action<HttpClient> configureGetSpecialsModelHttpClient,
            Action<IHttpClientBuilder> getSpecialsHttpClientBuilder,
            Action<HttpClient> configureGetToppingsModelHttpClient,
            Action<IHttpClientBuilder> getToppingsHttpClientBuilder)
        {
            IHttpClientBuilder Builder = services
                .AddHttpClient < IGetSpecialModel, 
                GetSpecialModel>(configureGetSpecialsModelHttpClient);

            getSpecialsHttpClientBuilder?.Invoke(Builder);


            IHttpClientBuilder GetToppingsBuilder = services
                .AddHttpClient<IGetToppingsModel,
                GetToppingsModel>(configureGetToppingsModelHttpClient);

            getToppingsHttpClientBuilder?.Invoke(GetToppingsBuilder);

            services.AddScoped<ICheckoutModel, CheckoutModel>();

            return services;
        }
    }
}
