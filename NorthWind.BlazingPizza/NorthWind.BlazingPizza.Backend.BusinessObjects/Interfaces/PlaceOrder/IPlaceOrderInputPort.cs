using NorthWind.BlazingPizza.Entities.DTOs.PlaceOrder;


namespace NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.PlaceOrder
{
    public interface IPlaceOrderInputPort
    {
        Task<int> PlaceOrderAsync(PlaceOrderOrderDto order);
    }
}
