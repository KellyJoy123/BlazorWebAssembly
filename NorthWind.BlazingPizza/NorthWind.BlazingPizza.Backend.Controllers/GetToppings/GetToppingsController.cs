using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Entities.ValueObjects;


namespace NorthWind.BlazingPizza.Backend.Controllers.GetToppings
{
    public static class GetToppingsController
    {
        public static WebApplication UseGetToppingsController(this WebApplication app)
        {
            app.MapGet(Endpoints.GetToppings, 
                async (IGetToppingsInputPort inputPort) =>
                TypedResults.Ok(await inputPort.GetToppingsAsync()));
            
            return app;
        }
    }
}
