namespace core.Service
{
    public interface IProvider
    {
        Task<IQueryable<ProviderModel>> GetAll();
    }
}
