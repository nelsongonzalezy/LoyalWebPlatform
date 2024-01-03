namespace core.Service
{
    public class CommissionService : ICommission
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public CommissionService(IHttpServicesUnAuthorized unAuthorized)
        {
            _unAuthorized = unAuthorized;
        }
        public async Task<CicloComisionesModel> GetCommissio(int CodigoCicloComisiones)
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseCicloComisionesModel>("api/v1/Comisiones/ConsultaComisiones?CodigoCicloComisiones="+ CodigoCicloComisiones);

            return y.Content;
        }
    }
}
