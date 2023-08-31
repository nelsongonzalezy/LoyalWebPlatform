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

        public IActionResult Detail() { return View(); }

    }
}
