using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.Entities.DTOs.GetOrders;


namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class GetOrdersRepository(
        IOrderDataSource dataSource) : IGetOrdersRepository
    {
        public Task<IEnumerable<GetOrdersDto>> GetOrdersSortedByDescendingIdAsync() =>
            dataSource.GetOrdersFromQueryAsync(
                orders => orders.OrderByDescending(o => o.Id)
                .Select(o=> new GetOrdersDto(
                    o.Id, 
                    o.CreatedTime, 
                    o.Pizzas.Count,
                    o.Pizzas.Sum(p=>p.TotalPrice),
                    o.Status)));
    }
}
