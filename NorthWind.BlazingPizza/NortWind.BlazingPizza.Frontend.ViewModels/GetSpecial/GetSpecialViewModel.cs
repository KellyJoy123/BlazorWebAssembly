namespace NortWind.BlazingPizza.Frontend.ViewModels.GetSpecial
{
    public class GetSpecialViewModel(IGetSpecialModel model)
    {
        public IEnumerable<PizzaSpecialDTO> Specials { get; private set; }

        public async Task GetSpecialAsync()
        {
            Specials = await model.GetSpecialsAsync();
        }
    }
}
