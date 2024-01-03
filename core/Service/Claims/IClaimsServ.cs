namespace core.Service
{
    public interface IClaimsServ
    {
        Task<IQueryable<ListarReclamosModel>> GetAll();

        Task<CreaReclamoInicialModel> Start(int CodigoReclamo = 0);
        Task<bool> CreateClaim(CreaReclamoInicialModel model);
        Task<ListarReclamosModel> GetClaimById(int CodigoReclamo);
    }
}
