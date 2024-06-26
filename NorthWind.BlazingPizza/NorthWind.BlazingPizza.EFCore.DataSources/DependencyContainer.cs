﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.DataSources;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;

namespace NorthWind.BlazingPizza.EFCore.DataSources
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDataSources(this IServiceCollection services, 
            Action<DBOptions> configureDBOptions) {
            services.AddScoped<IPizzaSpecialDataSource, PizzaSpecialDataSource>();
            services.AddScoped<IToppingDataSource, ToppingDataSource>();
            services.Configure(configureDBOptions);
            services.AddScoped<IPlaceOrderDataSource, PlaceOrderataSource>();
            services.AddScoped<IOrderDataSource, OrderDataSource>();

            return services;
        }
    }
}
