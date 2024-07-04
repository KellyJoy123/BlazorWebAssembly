using NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.Orders;
using NorthWind.BlazingPizza.Entities.DTOs.GetOrders;


namespace NortWind.BlazingPizza.Frontend.ViewModels.Orders
{
    public class OrdersViewModel(IOrdersModel model)
    {
        public IEnumerable<GetOrdersDto> Orders { get; set; }
        public async Task GetOrdersAsync() =>
            Orders = await model.GetOrdersAsync();
    }
}
