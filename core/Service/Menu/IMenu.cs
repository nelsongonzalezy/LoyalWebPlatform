namespace core.Service
{
    public interface IMenu
    {
        Task<IQueryable<MenuModel>> GetByUser();
    }
}
