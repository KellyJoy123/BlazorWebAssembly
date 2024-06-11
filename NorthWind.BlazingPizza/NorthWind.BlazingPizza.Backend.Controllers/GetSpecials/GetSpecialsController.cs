using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Controllers.GetSpecials
{
    public static class GetSpecialsController
    {
        public static WebApplication UseGetSpecialsController(this WebApplication app)
        {
            app.MapGet(Endpoints.GetSpecials,
                async (IGetSpecialsInputPort inputPort,
                IGetSpecialsOutputPort presenter) =>
                {
                    await inputPort.GetSpecialsAsync();
                    return TypedResults.Ok(presenter.PizzaSpecials);
                });


            return app;
        }

    }
}
