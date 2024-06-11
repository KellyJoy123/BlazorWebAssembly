using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.Entities.DTOs.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class GetSpecialsReporsitory(IPizzaSpecialDataSource dataSource) : IGetSpecialsRepository
    {
        public Task<IEnumerable<PizzaSpecialDTO>> GetSpecialsSortedByDescendingPriceAsync() 
            => dataSource.GetPizzaSpecialDTOsFromQueryAsync(pizzaSpecial => 
            pizzaSpecial
            .OrderByDescending(s=>s.BasePrice)
            .Select(s => new PizzaSpecialDTO(
                s.Id,
                s.Name,
                s.BasePrice,
                s.Description,
                s.ImageUrl
            )
            ));
        
    }
}
