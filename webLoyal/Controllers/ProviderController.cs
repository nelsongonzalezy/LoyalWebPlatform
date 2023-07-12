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
        [HttpGet]
        public async Task<IActionResult> Create(int ProviderCode)
        { 
            return View(await _provider.GetByCode(ProviderCode));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int ProviderCode)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProviderCreateModel model)
        {
            return View();
        }
    }
}
