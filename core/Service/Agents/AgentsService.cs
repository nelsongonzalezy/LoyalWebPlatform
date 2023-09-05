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
    }
}
