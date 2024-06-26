using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Extensions;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.Entities.DTOs.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class PlaceOrderRepository(
        IPlaceOrderDataSource dataSource) : IPlaceOrderRepository
    {
        public async Task<int> PlaceOrderAsync(PlaceOrderOrderDto order)
        {
            var Order = new Order();
            Order.CreatedTime = DateTime.Now;
            Order.Status = BlazingPizza.Entities.Enums.OrderStatus.Preparing;

            Order.Pizzas = order.Pizzas
                .Select(p=> p.ToCustomPizza()).ToList();


            await dataSource.PlaceOrderAsync(Order);
            return Order.Id;
        }
    }
}
