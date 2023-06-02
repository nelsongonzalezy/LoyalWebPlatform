using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
