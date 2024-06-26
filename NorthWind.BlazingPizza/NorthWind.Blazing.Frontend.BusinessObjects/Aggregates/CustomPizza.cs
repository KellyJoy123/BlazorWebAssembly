using NorthWind.Blazing.Frontend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Entities.DTOs.GetToppings;
using NorthWind.BlazingPizza.Entities.DTOs.PlaceOrder;

namespace NorthWind.Blazing.Frontend.BusinessObjects.Aggregates
{
    public class CustomPizza
    {
        readonly List<ToppingDto> ToppingsField = [];
        public CustomPizza(PizzaSpecialDTO special,
            BlazingPizzaOptions options)
        {
            Special = special;
            Options = options;
            Size = Options.DefaultPizzaSize;
        }
        public PizzaSpecialDTO Special { get; }
        public BlazingPizzaOptions Options { get; }
        public int Size { get; set; }
        public IEnumerable<ToppingDto> Toppings => ToppingsField;
        public bool HasMaximumTopings =>
            ToppingsField.Count >= Options.MaximumCustomPizzaToppings;
        public void AddTopping(ToppingDto topping)
        {
            if (!ToppingsField.Contains(topping))
            {
                ToppingsField.Add(topping);
            }
        }

        public void RemoveTopping(ToppingDto topping) => 
            ToppingsField.Remove(topping);


        public decimal GetBasePrice() =>
            (decimal) Size / Options.DefaultPizzaSize * Special.BasePrice;

        public decimal GetTotalPrice() =>
            GetBasePrice() + ToppingsField.Sum(t => t.Price);

        public string GetFormattedTotalPrice() =>
            GetBasePrice().ToString("$ 0.00");

        public string GetFormattedSizeWithTotalPrice() =>
            $"{Size} cm ({GetFormattedTotalPrice()})";

        public static explicit operator PlaceOrderPizzaDto(
            CustomPizza pizza) =>
            new PlaceOrderPizzaDto(
                pizza.Special.Id,
                pizza.Size,
                pizza.Toppings.Select(t => t.Id),
                pizza.GetTotalPrice()
                );

    }

}
