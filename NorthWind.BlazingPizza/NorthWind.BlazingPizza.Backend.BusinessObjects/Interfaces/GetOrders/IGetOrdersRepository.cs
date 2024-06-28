using NorthWind.BlazingPizza.Entities.DTOs.GetOrders;


namespace NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetOrders
{
    public interface IGetOrdersRepository
    {
        Task<IEnumerable<GetOrdersDto>> GetOrdersSortedByDescendingIdAsync();
    }
}
