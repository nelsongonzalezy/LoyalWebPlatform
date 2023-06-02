using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
