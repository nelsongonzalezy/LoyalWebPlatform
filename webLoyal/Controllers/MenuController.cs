using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenu _menu;

        public MenuController(IMenu menu) 
        {
            _menu = menu;
        }

        public async  Task<IActionResult> Index()
        {
            var x = await _menu.GetByUser();
            return View(x.ToList());
        }
        public async  Task<IActionResult> PartialMenu()
        {
            //var x = await _menu.GetByUser();
            //return View(x.ToList());
            return View();
        }
    }
}
