using NorthWind.BlazingPizza.Backend.Controllers.GetOrders;
using NorthWind.BlazingPizza.Backend.Controllers.GetSpecials;
using NorthWind.BlazingPizza.Backend.Controllers.GetToppings;
using NorthWind.BlazingPizza.Backend.Controllers.PlaceOrder;


//namespace NorthWind.BlazingPizza.Backend.Controllers
namespace Microsoft.AspNetCore.Builder
{
    public static class EndPointsContainer
    {
        public static WebApplication UseBlazingPizzaControllers(
            this WebApplication app)
        {
            app.UseGetSpecialsController();
            app.UseGetToppingsController();
            app.UsePlaceOrderController();
            app.UseGetOrdersController();

            return app;
        }
    }
}
