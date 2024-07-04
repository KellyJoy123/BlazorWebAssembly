
namespace NorthWind.BlazingPizza.Entities.DTOs.GetOrder
{
    public class GetOrderPizzaDto(
        string pizzaSpecialName,
        int size,
        IEnumerable<string> toppingsName,
        decimal totalPrice)
    {
        public string PizzaSpecialName => pizzaSpecialName;
        public int Size => size;
        public IEnumerable<string> ToppingsName => toppingsName;
        public decimal TotalPrice => totalPrice;
    }
}
