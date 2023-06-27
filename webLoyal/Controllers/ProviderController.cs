using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class ProviderController : Controller
    {
        private readonly IProvider _provider;

        public ProviderController(IProvider provider)
        {
            _provider = provider;
        }
        public async Task<IActionResult> Index()
        {
            var ret = await _provider.GetAll();
            return View(ret.ToList());
        }
    }
}
