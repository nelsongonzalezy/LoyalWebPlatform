using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class StagesController : BaseController
    {
        private readonly IForeCast _service;
        public StagesController(IForeCast requestMonitor)
        {
            _service = requestMonitor;
        }
        public async Task<IActionResult> Index()
        {
            var data  = await _service.GetListForeCast();
            return View(data.ToList());
        }
    }
}
