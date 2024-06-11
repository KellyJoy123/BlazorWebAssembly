using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.DTOs.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IPizzaSpecialDataSource
    {
        Task<IEnumerable<PizzaSpecialDTO>> GetPizzaSpecialDTOsFromQueryAsync(
            Func<IQueryable<PizzaSpecial>, 
                IQueryable<PizzaSpecialDTO>> queryBuilder);
    }
}
