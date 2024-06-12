using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Entities.DTOs.GetToppings;

namespace NorthWind.BlazingPizza.Backend.UseCases.GetToppings
{
    public class GetToppingsInteractor(
        IGetToppingsRepository repository) : IGetToppingsInputPort
    {
        public Task<IEnumerable<ToppingDto>> GetToppingsAsync() =>
            repository.GetToppingsSortedByNameAscendingAsync();
    }
}
