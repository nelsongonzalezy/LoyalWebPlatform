namespace core.Service
{
    public interface IClaimsReports
    {
        Task<IQueryable<ClaimsReportsDetailModel>> GetAll();
    }
}
