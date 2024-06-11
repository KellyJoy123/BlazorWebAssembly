namespace NorthWind.Blazing.Frontend.BusinessObjects.Interfaces.GetSpecials
{
    public interface IGetSpecialModel
    {
        Task<IEnumerable<PizzaSpecialDTO>> GetSpecialsAsync();
    }
}
