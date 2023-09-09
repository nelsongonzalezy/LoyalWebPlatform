using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class PoliciesController : Controller
    {
        private readonly IPolicies _request;
        public PoliciesController(IPolicies request)
        {
            _request = request;
        }
        public async Task<IActionResult> Index()
        {
            var x = await _request.GetAll();
            return View(x.ToList());
        }
        [HttpGet]
        [Route("Policies/Detail/{codigoSolicitud}")]
        public async Task<IActionResult> Detail(int codigoSolicitud) 
        { 
            var model = await _request.GetByCode(codigoSolicitud);
            return View(model); 
        }

        public async Task<IActionResult> Renewal()
        {
            var x = await _request.GetFiguresRenewal();
            return View(x.ToList());
        }

    }
}
