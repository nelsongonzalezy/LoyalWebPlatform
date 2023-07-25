using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class draftController : Controller
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
