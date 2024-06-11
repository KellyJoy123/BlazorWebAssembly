using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Entities.DTOs.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.Presenters.GetSpecials
{
    internal class GetSpecialsPresenter(IOptions<BlazingPizzaOptions> options) : IGetSpecialsOutputPort
    {
        public IEnumerable<PizzaSpecialDTO> PizzaSpecials { get; private set; }

        public Task HandlerResultAsync(IEnumerable<PizzaSpecialDTO> pizzaSpecials)
        {
            PizzaSpecials = pizzaSpecials
                   .Select(s => new PizzaSpecialDTO
                   (
                       s.Id, 
                       s.Name, 
                       s.BasePrice, 
                       s.Description, 
                       $"{options.Value.ImageUrlBase}/{s.ImageUrl}"
                       )
                   );
            return Task.CompletedTask;
        }
    }
}
