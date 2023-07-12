namespace core.Service
{
    public class CountriesServices : ICountries
    {
        public async Task<IQueryable<CountryListModel>> GetAll()
        {
            var x= new List<CountryListModel>();
            return x.AsQueryable();
        }
    }
}
