namespace NorthWind.BlazingPizza.Frontend.WebApiProxy
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddModels(
            this IServiceCollection services,
            Action<HttpClient> configureGetSpecialsModelHttpClient,
            Action<IHttpClientBuilder> getSpecialsHttpClientBuilder)
        {
            IHttpClientBuilder Builder = services
                .AddHttpClient < IGetSpecialModel, 
                GetSpecialModel>(configureGetSpecialsModelHttpClient);

            getSpecialsHttpClientBuilder?.Invoke(Builder);

            return services;
        }
    }
}
