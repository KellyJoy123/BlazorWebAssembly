using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Entities.DTOs.PlaceOrder;


namespace NorthWind.BlazingPizza.Backend.UseCases.PlaceOrder
{
    internal class PlaceOrderInteractor(IPlaceOrderRepository repository) : IPlaceOrderInputPort
    {
        public async Task<int> PlaceOrderAsync(PlaceOrderOrderDto order) =>
            await repository.PlaceOrderAsync(order);
    }
}
