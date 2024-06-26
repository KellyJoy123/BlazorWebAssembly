using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.DataContext;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;


namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
    internal class PlaceOrderataSource(
        IOptions<DBOptions> options) :
        BlazingPizzaContext(options), 
        IPlaceOrderDataSource
    {
        public async Task PlaceOrderAsync(Order order)
        {
            Orders.Add(order);
            await SaveChangesAsync();
        }
    }
}
