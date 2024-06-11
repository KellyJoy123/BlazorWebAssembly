namespace NortWind.BlazingPizza.Frontend.ViewModels
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {

            services.TryAddScoped<GetSpecialViewModel>();
            return services;
        }
    }
}
