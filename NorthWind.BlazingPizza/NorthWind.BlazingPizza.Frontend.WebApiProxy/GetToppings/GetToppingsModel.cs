using NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Entities.DTOs.GetToppings;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxy.GetToppings
{
    internal class GetToppingsModel(HttpClient client) :
        IGetToppingsModel
    {
        IEnumerable<ToppingDto> Toppings;
        public async Task<IEnumerable<ToppingDto>> GetToppingsAsync()
        {
            if (Toppings == null) 
            {
                Toppings = await client
                    .GetFromJsonAsync<IEnumerable<ToppingDto>>(
                    Endpoints.GetToppings);
            }
            return Toppings;
        }
    }
}
