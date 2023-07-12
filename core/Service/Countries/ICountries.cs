namespace core.Service
{
    public interface ICountries
    {
        Task<IQueryable<CountryListModel>> GetAll(); 
    }
}
