using NorthWind.BlazingPizza.Entities.DTOs.GetToppings;


namespace NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.GetToppings
{
    public interface IGetToppingsModel
    {
        Task<IEnumerable<ToppingDto>> GetToppingsAsync();
    }
}
