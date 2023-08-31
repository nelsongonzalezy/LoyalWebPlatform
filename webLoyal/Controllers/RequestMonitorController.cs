using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class RequestMonitorController : Controller
    {
        private readonly IRequestMonitor _requestMonitor;
        public RequestMonitorController(IRequestMonitor requestMonitor)
        {
            _requestMonitor = requestMonitor;
        }
        [HttpGet]
        [Route("RequestMonitor/Index")]
        public async Task<IActionResult> Index()
        {
            var model = await _requestMonitor.GetAlList();
                return View(model.ToList());
        }
        [HttpGet]
        [Route("RequestMonitor/Detail/{CodigoSolicitud}")]
        public async Task<IActionResult> Detail(int CodigoSolicitud)
        {
            var model = await _requestMonitor.Getbyid(CodigoSolicitud);
            return View(model.ToList());
        }
    }
}
