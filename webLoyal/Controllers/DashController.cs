using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class DashController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
