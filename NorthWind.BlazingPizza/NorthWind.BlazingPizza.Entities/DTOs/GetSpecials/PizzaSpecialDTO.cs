namespace NorthWind.BlazingPizza.Entities.DTOs.GetSpecials
{
    public class PizzaSpecialDTO(
        int id,
        string name,
        decimal basePrice,
        string description,
        string imageUrl
        )
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public string Description { get; } = description;
        public decimal BasePrice { get; } = basePrice;
        public string ImageUrl { get; } = imageUrl;

        public string FormattedBasePrice => BasePrice.ToString("0.00");

    }
}
