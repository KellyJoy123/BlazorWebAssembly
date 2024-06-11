namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class CardSpecial
    {
        [Inject] private GetSpecialViewModel ViewModel { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await ViewModel.GetSpecialAsync();
        }
    }
}
