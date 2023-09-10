namespace core.Service
{
    public interface IAgents
    {
        Task<IQueryable<AgentsDetailModel>> GetAgentsById(string codigoAgente);
        Task<IQueryable<AgentsDetailModel>> GetAll();
    }
}
