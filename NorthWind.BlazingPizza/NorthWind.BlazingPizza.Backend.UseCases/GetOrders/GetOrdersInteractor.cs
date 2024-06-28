using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Entities.DTOs.GetOrders;


namespace NorthWind.BlazingPizza.Backend.UseCases.GetOrders
{
    internal class GetOrdersInteractor(IGetOrdersRepository repository) :
        IGetOrdersInputPort
    {
        public Task<IEnumerable<GetOrdersDto>> GetOrdersAsync() =>
            repository.GetOrdersSortedByDescendingIdAsync();
    }
}
