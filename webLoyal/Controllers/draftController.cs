using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class DraftController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
