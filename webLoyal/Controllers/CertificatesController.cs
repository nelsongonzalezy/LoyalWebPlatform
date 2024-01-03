using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class CertificatesController : BaseController
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var viewes = new CertificatesDetailModel();
            return View(viewes);
        }
    }
}
