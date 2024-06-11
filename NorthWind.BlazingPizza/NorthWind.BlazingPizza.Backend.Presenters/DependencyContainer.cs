using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.Presenters.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.Presenters
{
    public static class DependencyContainer
    {
         public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsOutputPort, GetSpecialsPresenter>();
            return services;
        }
    }
}
