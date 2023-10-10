namespace core.Service
{
    public class AgentsService : IAgents
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public AgentsService(IHttpServicesUnAuthorized unAuthorized)
        {
            this._unAuthorized = unAuthorized;
        }
       

        public async Task<IQueryable<AgentsDetailModel>> GetAgentsById(string codigoAgente)
        {
            var model = await _unAuthorized.GetUnAuthorizedAsync<ResponseAgentsDetailModel>("api/v1/Agente?codigoAgente="+codigoAgente);
            return model.Content.AsQueryable();
        }
        public async Task<IQueryable<AgentsDetailModel>> GetAll()
        {
            var model = await _unAuthorized.GetUnAuthorizedAsync<ResponseAgentsDetailModel>("api/v1/Agente?codigoAgente=");
            return model.Content.AsQueryable();
        }        
        public async Task<ConsultaAgentesCarteraModel> GetAgentAndwallet(int CodigoAgentePrincipal, string CodigoEstadoCertificado, int CodigoAgente, string CodigoTipoVenta)
        {
            var model = await _unAuthorized.GetUnAuthorizedAsync<ResponseConsultaAgentesCarteraModel>("api/v1/Agente/ObtenAgentescartera?CodigoAgentePrincipal="+ CodigoAgentePrincipal + "&CodigoEstadoCertificado="+ CodigoEstadoCertificado + "&CodigoAgente="+CodigoAgente+"&CodigoTipoVenta="+ CodigoTipoVenta);
            return model.Content;
        }
    }
}
