using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.Entities.DTOs.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class GetToppingsRepository(
        IToppingDataSource dataSource) : IGetToppingsRepository
    {
        public Task<IEnumerable<ToppingDto>> GetToppingsSortedByNameAscendingAsync() =>
            dataSource.GetToppingDtosFromQueryAsync(
                toppings => toppings
                .OrderBy(t => t.Name)
                .Select(t => new ToppingDto(
                    t.Id,
                    t.Name,
                    t.Price)
                ));
    }
}
