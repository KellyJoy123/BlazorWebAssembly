using Microsoft.Extensions.Options;
using NorthWind.Blazing.Frontend.BusinessObjects.Aggregates;
using NorthWind.Blazing.Frontend.BusinessObjects.Options;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class ConfigurePizzaDialog
    {
        [Inject]
        ConfigurePizzaDialogViewModel ViewModel { get; set; }

        [Inject]
        IOptions<BlazingPizzaOptions> Options { get; set; }

        [Parameter]
        public CustomPizza CustomPizza { get; set; }

        [Parameter]
        public EventCallback OnCancel { get; set; }

        [Parameter]
        public EventCallback OnConfirm { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await ViewModel.GetToppingsAsync();
        }

        void ToppingSelected(ChangeEventArgs e) =>
            CustomPizza.AddTopping(
                ViewModel.Toppings
                .First(t => t.Id == Convert.ToInt32(e.Value)));
    }
}