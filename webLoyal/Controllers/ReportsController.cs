using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class ReportsController : BaseController
    {
        private readonly IClaimsReports _ClaimReports;
        public ReportsController(IClaimsReports claimReports) { _ClaimReports = claimReports; }
        public async Task<IActionResult> Index()
        {
            var ret = await _ClaimReports.GetAll();
            return View(ret.ToList());
        }
    }
}
