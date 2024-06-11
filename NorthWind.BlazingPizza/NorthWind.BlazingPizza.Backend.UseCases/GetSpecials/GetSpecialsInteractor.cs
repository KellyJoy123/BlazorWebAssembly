using NorthWind.BlazingPizza.Backend.BusinessObjects.Interfaces.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.UseCases.GetSpecials
{
    internal class GetSpecialsInteractor(
        IGetSpecialsRepository repository, 
        IGetSpecialsOutputPort presenter) : IGetSpecialsInputPort
    {
        public async Task GetSpecialsAsync()
        {
            var Specials = await repository.GetSpecialsSortedByDescendingPriceAsync();
            await presenter.HandlerResultAsync(Specials);
        }
    }
}
