using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class ProviderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
