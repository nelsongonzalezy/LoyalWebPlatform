namespace core.Service
{
    public interface IBoardService
    {
        Task<IQueryable<BoardAgentsModel>> GetBoardAgents();
    }
}
