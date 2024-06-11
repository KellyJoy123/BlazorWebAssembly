using NorthWind.BlazingPizza.Entities.ValueObjects;
using System.Net.Http.Json;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxy.GetSpecials
{
    internal sealed class GetSpecialModel(HttpClient client) : IGetSpecialModel
    {
        IEnumerable<PizzaSpecialDTO> Specials;


        public async Task<IEnumerable<PizzaSpecialDTO>> GetSpecialsAsync()
        {
            if (Specials == null)
            {
                Specials = await client
                    .GetFromJsonAsync<IEnumerable<PizzaSpecialDTO>>(Endpoints.GetSpecials);
            }
            return Specials;
        }
    }
}
