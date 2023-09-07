using System.Reflection.Emit;

namespace core.Service
{
    public class ClaimsService : IClaimsServ
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public ClaimsService(IHttpServicesUnAuthorized unAuthorized) { this._unAuthorized = unAuthorized; }

        public async Task<IQueryable<ListarReclamosModel>> GetAll()
        {
            var x = await _unAuthorized.GetUnAuthorizedAsync<ResposeListarReclamosModel>("api/v1/Reclamos/ListaReclamos");
            //var claims = await HttpServices.GetAuthorizedAsync<List<ClaimListModel>>("api/Claim/GetAll", LoginService.Token);
            return x.Content.AsQueryable();

        }
    }
}
