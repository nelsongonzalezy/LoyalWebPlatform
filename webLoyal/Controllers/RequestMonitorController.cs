using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class RequestMonitorController : Controller
    {
        [HttpGet]
        [Route("RequestMonitor/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("RequestMonitor/Detail")]
        public IActionResult Detail()
        {
            return View();
        }
    }
}
