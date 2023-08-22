namespace core.Service
{
    public interface IProduct
    {
        Task<IQueryable<ProducComponentModel>> GetProducComponent();
    }
}
