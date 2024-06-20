using NorthWind.BlazingPizza.Entities.DTOs.GetSpecials;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class CardSpecial
    {
        [Inject]  
        GetSpecialViewModel ViewModel { get; set; }

        [Parameter]
        public EventCallback<PizzaSpecialDTO> OnClickSpecial { get; set; }

         override protected async Task OnInitializedAsync()
        {
            await ViewModel.GetSpecialAsync();
        }
    }
}
