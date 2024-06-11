using NorthWind.BlazingPizza.Entities.DTOs.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetSpecials
{
    public interface IGetSpecialsOutputPort
    {
        IEnumerable<PizzaSpecialDTO> PizzaSpecials { get; }
        Task HandlerResultAsync(IEnumerable<PizzaSpecialDTO> pizzaSpecials);
    }
}
