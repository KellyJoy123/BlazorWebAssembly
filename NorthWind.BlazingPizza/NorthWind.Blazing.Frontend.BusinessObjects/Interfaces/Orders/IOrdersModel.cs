using NorthWind.BlazingPizza.Entities.DTOs.GetOrders;


namespace NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.Orders
{
    public interface IOrdersModel
    {
        Task<IEnumerable<GetOrdersDto>> GetOrdersAsync();
    }
}
