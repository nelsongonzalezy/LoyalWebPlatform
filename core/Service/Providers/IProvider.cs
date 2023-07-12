using System.Reflection;

namespace core.Service
{
    public interface IProvider
    {
        Task<IQueryable<ProviderListModel>> GetAll();
        Task<ProviderCreateModel> GetByCode(int ProviderCode);
        Task<bool> Update(ProviderCreateModel model);
        Task<bool> Create(ProviderCreateModel model);
    }
}
