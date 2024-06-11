﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.UseCases.GetSpecials;
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

            return services;
        }
    }
}
