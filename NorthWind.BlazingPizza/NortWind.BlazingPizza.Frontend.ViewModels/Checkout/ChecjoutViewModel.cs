using NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.Checkout;
using NorthWind.Blazing.Frontend.BusinessObjects.Services;


namespace NortWind.BlazingPizza.Frontend.ViewModels.Checkout
{
    public class ChecjoutViewModel(
        ICheckoutModel model,
        ShoppingCart shoppingCart)
    {
        public bool IsSubmitting { get; set; }
        public async Task<int> PlaceOrderAsync()
        {
            IsSubmitting = true;
            int OrderId = await model.PlaceOrderAsync(shoppingCart);
            shoppingCart.ResetShoppingCart();
            IsSubmitting = false;
            return OrderId;
        }
    }
}
