namespace core.Service
{
    public interface IBoardService
    {
        Task<IQueryable<BoardAgentsModel>> GetBoardAgents();
        Task<ConsultaVentasGeneralModel> GetSales(int year, int month);
    }
}
