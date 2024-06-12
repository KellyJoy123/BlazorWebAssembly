using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.DTOs.GetToppings;


namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IToppingDataSource
    {
        Task<IEnumerable<ToppingDto>> GetToppingDtosFromQueryAsync(
            Func<IQueryable<Topping>, IQueryable<ToppingDto>> queryBuilder);
    }
}
