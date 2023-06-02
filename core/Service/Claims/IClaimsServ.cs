namespace core.Service
{
    public interface IClaimsServ
    {
        Task<IQueryable<ClaimCreateModel>> GetAll();
    }
}
