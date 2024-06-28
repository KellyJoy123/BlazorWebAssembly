using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Backend.UseCases.GetOrders;
using NorthWind.BlazingPizza.Backend.UseCases.GetSpecials;
using NorthWind.BlazingPizza.Backend.UseCases.GetToppings;
using NorthWind.BlazingPizza.Backend.UseCases.PlaceOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsInputPort, GetSpecialsInteractor>();

            services.AddScoped<IGetToppingsInputPort, GetToppingsInteractor>();

            services.AddScoped<IPlaceOrderInputPort, PlaceOrderInteractor>();

            services.AddScoped<IGetOrdersInputPort, GetOrdersInteractor>();

            return services;
        }
    }
}
