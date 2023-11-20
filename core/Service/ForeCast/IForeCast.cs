namespace core.Service
{
    public interface IForeCast
    {
        Task<IQueryable<ForeCastModel>> GetListForeCast();
    }
}
