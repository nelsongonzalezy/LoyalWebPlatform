namespace core.Service
{
    public interface ICommission
    {
        Task<CicloComisionesModel> GetCommissio(int CodigoCicloComisiones);
    }
}
