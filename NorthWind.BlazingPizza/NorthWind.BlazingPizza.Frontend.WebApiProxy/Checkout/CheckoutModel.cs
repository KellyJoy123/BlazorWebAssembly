using NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.Checkout;
using NorthWind.Blazing.Frontend.BusinessObjects.Services;
using NorthWind.BlazingPizza.Entities.DTOs.PlaceOrder;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using System.Net.Http.Json;


namespace NorthWind.BlazingPizza.Frontend.WebApiProxy.Checkout
{
    internal class CheckoutModel(HttpClient client) : ICheckoutModel
    {
        public async Task<int> PlaceOrderAsync(ShoppingCart order)
        {
            int OrderId = 0;
            var Response = await client.PostAsJsonAsync(Endpoints.PlaceOrder,
                (PlaceOrderOrderDto)order);
            if (Response.IsSuccessStatusCode)
            {
                OrderId = await Response.Content.ReadFromJsonAsync<int>();
            }

            return OrderId;
        }
    }
}
