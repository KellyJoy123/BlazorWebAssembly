using Microsoft.AspNetCore.Builder;
using NorthWind.BlazingPizza.Backend.Controllers.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.IoC
{
    public static class EndpointContainer
    {

        public static WebApplication UseBlazingPizzaEndpoints(this WebApplication app) {

            app.UseGetSpecialsController();
            return app;
        }
    }
}
