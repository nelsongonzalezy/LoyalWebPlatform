using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class MenuController : BaseController
    {
        private readonly IMenu _menu;
        private readonly IPolicies _Policies;

        public MenuController(IMenu menu, IPolicies Policies) 
        {
            _menu = menu;
            _Policies = Policies;
        }

        public async  Task<IActionResult> Index()
        {
            var x = await _Policies.GetpoliciesForCountry();
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
