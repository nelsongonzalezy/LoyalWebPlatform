namespace core.Service
{
    public interface IDraft
    {
        Task<IQueryable<DraftStatusModel>> GetAllStatus();
    }
}
