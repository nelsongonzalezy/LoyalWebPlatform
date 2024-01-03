namespace core.Service
{
    public interface IAgents
    {
        Task<IQueryable<AgentsDetailModel>> GetAgentsById(string codigoAgente);
        Task<IQueryable<AgentsDetailModel>> GetAll();
        Task<ConsultaAgentesCarteraModel> GetAgentAndwallet(int CodigoAgentePrincipal, string CodigoEstadoCertificado, int CodigoAgente, string CodigoTipoVenta);
    }
}
