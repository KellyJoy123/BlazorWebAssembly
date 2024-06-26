using NortWind.BlazingPizza.Frontend.ViewModels.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Pages
{
    public partial class Checkout
    {
        [Inject]
        ChecjoutViewModel ViewModel { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        async Task PlaceOrder()
        {
            await ViewModel.PlaceOrderAsync();
            NavigationManager.NavigateTo("/");
        }
    }
}
