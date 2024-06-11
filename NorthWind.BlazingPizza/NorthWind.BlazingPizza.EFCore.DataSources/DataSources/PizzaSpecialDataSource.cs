using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.DataContext;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Entities.DTOs.GetSpecials;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
    internal class PizzaSpecialDataSource : BlazingPizzaContext, IPizzaSpecialDataSource
    {
        public PizzaSpecialDataSource(IOptions<DBOptions> options):base(options) { 
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public async Task<IEnumerable<PizzaSpecialDTO>> GetPizzaSpecialDTOsFromQueryAsync(Func<IQueryable<PizzaSpecial>, IQueryable<PizzaSpecialDTO>> queryBuilder)
        {
            IQueryable<PizzaSpecialDTO> Query = queryBuilder(PizzaSpecials);
            return await Query.ToListAsync();
        }
    }
}
