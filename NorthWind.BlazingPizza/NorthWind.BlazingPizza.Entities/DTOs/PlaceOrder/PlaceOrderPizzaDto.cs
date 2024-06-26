using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Entities.DTOs.PlaceOrder
{
    public class PlaceOrderPizzaDto(
        int pizzaSpecialId,
        int size, 
        IEnumerable<int> toppingsId, 
        decimal totalPrice)
    {
        public int PizzaSpecialId  => pizzaSpecialId;
        public int Size => size;
        public IEnumerable<int> ToppingsId => toppingsId;
        public decimal TotalPrice => totalPrice;
    }
}
