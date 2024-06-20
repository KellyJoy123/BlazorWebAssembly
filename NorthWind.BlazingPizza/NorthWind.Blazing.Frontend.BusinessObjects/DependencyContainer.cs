using Microsoft.Extensions.DependencyInjection;
using NorthWind.Blazing.Frontend.BusinessObjects.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Blazing.Frontend.BusinessObjects
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBusinessObjectsServices(
            this IServiceCollection services)
        {
            services.AddScoped<ShoppingCart>();

            return services;
        }
    }
}
