using NorthWind.BlazingPizza.Entities.DTOs.GetOrders;


namespace NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetOrders
{
    public interface IGetOrdersInputPort
    {
        Task<IEnumerable<GetOrdersDto>> GetOrdersAsync();
    }
}
