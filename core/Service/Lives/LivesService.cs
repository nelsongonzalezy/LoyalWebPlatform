namespace core.Service
{
    public class LivesService : ILives
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public LivesService(IHttpServicesUnAuthorized unAuthorized)
        {
            this._unAuthorized = unAuthorized;
        }
        public async Task<VidasResponseModel> GetAllLife()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseVidasResponseModel>("api/v1/Vidas/ObtenerVidas");
            return y.Content;
        }        
        public async Task<IQueryable<CifrasPersonasCertificadoResponseModel>> GetAllCountLife()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseCifrasPersonasCertificadoResponseModel>("api/v1/Vidas/ObtenerCifrasVidas");
            return y.Content.AsQueryable();
        }
    }
}
