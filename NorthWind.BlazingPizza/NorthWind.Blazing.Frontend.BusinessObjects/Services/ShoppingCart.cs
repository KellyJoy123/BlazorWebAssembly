﻿using NorthWind.Blazing.Frontend.BusinessObjects.Aggregates;
using NorthWind.BlazingPizza.Entities.DTOs.PlaceOrder;

namespace NorthWind.Blazing.Frontend.BusinessObjects.Services
{
    public class ShoppingCart
    {
        readonly List<CustomPizza> PizzasField = [];
        public IEnumerable<CustomPizza> Pizzas => PizzasField;
        public void AddPizza(CustomPizza pizza) =>
            PizzasField.Add(pizza);
        public void RemovePizza(CustomPizza pizza) =>
            PizzasField.Remove(pizza);

        public void ResetShoppingCart()
        {
            PizzasField.Clear();
        }
        public decimal GetTotalPrice() =>
            PizzasField.Sum(p => p.GetTotalPrice());
        public string GetFormattedTotalPrice() =>
            GetTotalPrice().ToString("0.00");
        public bool HasPizzas => PizzasField.Any();

        public static explicit operator PlaceOrderOrderDto(ShoppingCart shoppingCart) =>
            new PlaceOrderOrderDto(
                shoppingCart.Pizzas.Select(p => (PlaceOrderPizzaDto)p)
                );

    }
}
