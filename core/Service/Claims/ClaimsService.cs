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
        public async Task<CreaReclamoInicialModel> Start(int CodigoReclamo=0)
        {
            var x = await _unAuthorized.GetUnAuthorizedAsync<ResponseCreaReclamoInicialModel>("api/v1/Reclamos/ReclamosInicial?CodigoReclamo="+CodigoReclamo);
            //var claims = await HttpServices.GetAuthorizedAsync<List<ClaimListModel>>("api/Claim/GetAll", LoginService.Token);
            return x.Content;

        }        
        public async Task<bool> CreateClaim(CreaReclamoInicialModel model)
        {
            var x = await _unAuthorized.PostUnAuthorizedAsync<CreaReclamoInicialModel, bool>("api/v1/Reclamos/ReclamosInicial?CodigoReclamo=",model);
            //var claims = await HttpServices.GetAuthorizedAsync<List<ClaimListModel>>("api/Claim/GetAll", LoginService.Token);
            return x;

        } 
        public async Task<ListarReclamosModel> GetClaimById(int CodigoReclamo)
        {
            var x = await _unAuthorized.GetUnAuthorizedAsync<ResposeReclamosModel>("api/v1/Reclamos/ReclamosDetalle?CodigoReclamo=" + CodigoReclamo);
            //var claims = await HttpServices.GetAuthorizedAsync<List<ClaimListModel>>("api/Claim/GetAll", LoginService.Token);
            return x.Content;

        }
    }
}
