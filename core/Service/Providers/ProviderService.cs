namespace core.Service
{
    public class ProviderService : IProvider
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        private readonly ICountries _countries;
        public ProviderService(ICountries countries, IHttpServicesUnAuthorized unAuthorized)
        {
            _countries = countries;
            _unAuthorized = unAuthorized;
        }
        public async Task<IQueryable<ListarProveedoresModel>> GetAll()
        {

            var provider = await _unAuthorized.GetUnAuthorizedAsync<ResponseListarProveedoresModel>("api/v1/Proveedor/ListaProveedores");


            return provider.Content.AsQueryable();

        }

        public async Task<ProviderCreateModel> GetByCode(int ProviderCode)
        {
            if (ProviderCode == 0)
            {
                return new ProviderCreateModel
                {
                    Countries = await _countries.GetAll()
                };
            }
            else
            {
                return new ProviderCreateModel
                {
                    Countries = await _countries.GetAll()
                };
            }
           
           
        }
        public async Task<bool> Update(ProviderCreateModel model)
        {
            return true;
        }
        public async Task<bool> Create(ProviderCreateModel model)
        {
            return true;
        }
    }
}
