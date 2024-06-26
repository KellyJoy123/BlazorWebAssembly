﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Backend.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IGetSpecialsRepository, GetSpecialsReporsitory>();
            services.AddScoped<IGetToppingsRepository, GetToppingsRepository>();
            services.AddScoped<IPlaceOrderRepository, PlaceOrderRepository>();
            return services;
        }
    }
}
