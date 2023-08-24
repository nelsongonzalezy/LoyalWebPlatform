namespace core.Service
{
    public class PoliciesServices : IPolicies
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public PoliciesServices(IHttpServicesUnAuthorized unAuthorized)
        {
            this._unAuthorized = unAuthorized;
        }
        public async Task<IQueryable<CertificadosModel>> GetAllStatus()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestCertificadosModel>("api/v1/Certificados/ObtenerCertificados");
           
            
            return y.Content.AsQueryable();
        }
    }
}
