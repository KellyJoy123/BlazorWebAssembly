

using NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.Orders;
using NorthWind.BlazingPizza.Entities.DTOs.GetOrders;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxy.Orders
{
    internal class OrdersModel(HttpClient client) : IOrdersModel
    {
        public async Task<IEnumerable<GetOrdersDto>> GetOrdersAsync()
        {
            return await client.GetFromJsonAsync<IEnumerable<GetOrdersDto>>(Endpoints.GetOrders);
        }
    }
}
