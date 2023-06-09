using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class StagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
