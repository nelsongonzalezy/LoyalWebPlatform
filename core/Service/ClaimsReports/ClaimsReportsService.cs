namespace core.Service
{
    public class ClaimsReportsService : IClaimsReports
    {
        public ClaimsReportsService() { }

        public async Task<IQueryable<ClaimsReportsDetailModel>> GetAll()
        {
            var ret = new List<ClaimsReportsDetailModel>();
            for (int i = 3; i <= 10; i++)
            {
                ret.Add(new ClaimsReportsDetailModel
                {
                    ClaimsReportsId = i,
                    ClaimsReportFormat = $"Proveedor {i}",
                    PolicyCode = "0000-00-000"+i.ToString(),
                    ClaimId = i,
                    ClaimValue = 15432*i,
                    ReportClaimDate = DateTime.Now
                });
            }

            return ret.AsQueryable();
        }
    }
}
