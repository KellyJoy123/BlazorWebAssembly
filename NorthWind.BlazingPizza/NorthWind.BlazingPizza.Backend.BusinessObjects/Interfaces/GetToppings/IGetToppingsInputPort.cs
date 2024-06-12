using NorthWind.BlazingPizza.Entities.DTOs.GetToppings;

namespace NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetToppings
{
    public interface IGetToppingsInputPort
    {
        Task<IEnumerable<ToppingDto>> GetToppingsAsync();
    }
}
