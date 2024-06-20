using Microsoft.Extensions.Options;
using NorthWind.Blazing.Frontend.BusinessObjects.Aggregates;
using NorthWind.Blazing.Frontend.BusinessObjects.Options;
using NorthWind.Blazing.Frontend.BusinessObjects.Services;


namespace NortWind.BlazingPizza.Frontend.ViewModels.Index
{
    public class IndexViewModel(IOptions<BlazingPizzaOptions> options,
        ShoppingCart shoppingCart)
    {
        public CustomPizza CustomPizza { get; set; }

        public bool ShowConfigureDialog { get; set; }

        public void ConfigurePizza(PizzaSpecialDTO special)
        {
            CustomPizza = new CustomPizza(special, options.Value);
            ShowConfigureDialog = true;
        }

        public void CancelConfigurePizza()
        {
            CustomPizza = null;
            ShowConfigureDialog = false;
        }

        public void ConfirmConfigurePizza()
        {
            shoppingCart.AddPizza(CustomPizza);

            foreach(var Pizza in shoppingCart.Pizzas)
            {
                Console.WriteLine(Pizza.Special.Name);
            }

            CustomPizza = null;
            ShowConfigureDialog = false;
            
        }
    }
}
