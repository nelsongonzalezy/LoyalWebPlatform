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
        public async Task<IActionResult> Details(int CodigoPeriodo, string CodigoTipoVenta)
        {
            ViewBag.CodigoTipoVenta = CodigoTipoVenta;
            var data = await _service.GetDetailsForeCast(CodigoPeriodo, CodigoTipoVenta);
            return View(data);
        }
        public async Task<IActionResult> Total()
        {
            var data = await _service.GetForeCastTotal();
            return View(data);
        }
        public async Task<IActionResult> TotalPeriodo(int CodigoPeriodo)
        {
            var data = await _service.GetForeCastTotal(CodigoPeriodo);
            return View(data);
        }
    }
}
