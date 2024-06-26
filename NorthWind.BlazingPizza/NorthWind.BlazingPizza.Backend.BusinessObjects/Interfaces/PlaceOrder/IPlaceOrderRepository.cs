using NorthWind.BlazingPizza.Entities.DTOs.PlaceOrder;


namespace NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.PlaceOrder
{
    public interface IPlaceOrderRepository
    {
        Task<int> PlaceOrderAsync(PlaceOrderOrderDto order);
    }
}
