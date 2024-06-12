using NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Entities.DTOs.GetToppings;

namespace NortWind.BlazingPizza.Frontend.ViewModels.ConfigurePizzaDialog
{
    public class ConfigurePizzaDialogViewModel(IGetToppingsModel toppingsModel)
    {
        public IEnumerable<ToppingDto> Toppings { get; private set; }

        public async Task GetToppings() =>
            Toppings = await toppingsModel.GetToppingsAsync();
    }
}
