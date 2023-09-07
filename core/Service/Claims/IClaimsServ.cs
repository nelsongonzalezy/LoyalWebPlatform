namespace core.Service
{
    public interface IClaimsServ
    {
        Task<IQueryable<ListarReclamosModel>> GetAll();
    }
}
