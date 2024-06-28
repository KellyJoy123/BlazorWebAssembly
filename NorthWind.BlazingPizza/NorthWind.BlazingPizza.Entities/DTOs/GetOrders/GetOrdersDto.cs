using NorthWind.BlazingPizza.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Entities.DTOs.GetOrders
{
    public class GetOrdersDto(
        int id, DateTime createdTime,
        int pizzaCount,
        decimal totalPrice, 
        OrderStatus status)
    {
        public int Id => id;
        public DateTime CreateTime => createdTime;
        public int PizzaCount => pizzaCount;
        public decimal TotalPrice => totalPrice;
        public OrderStatus Status => status;

        public string GetFormatteTotalPrice() => totalPrice.ToString("0.00");

    }
}
