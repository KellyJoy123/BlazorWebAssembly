using NorthWind.Blazing.Frontend.BusinessObjects.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.Checkout
{
    public interface ICheckoutModel
    {
        Task<int> PlaceOrderAsync(ShoppingCart order);
    }
}
