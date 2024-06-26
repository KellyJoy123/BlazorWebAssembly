using NorthWind.Blazing.Frontend.BusinessObjects.Services;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class OrderReview
    {
        [Inject]
        ShoppingCart ShoppingCart { get; set; }
    }
}