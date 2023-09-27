using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class StagesController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
