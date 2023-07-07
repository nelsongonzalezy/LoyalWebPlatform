using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        [Route("Profile/Index")]
        public IActionResult Index(int ProfilesId)
        {
            return View();
        } 
        [HttpPost]
        [Route("Profile/Index")]
        public IActionResult qweIndex(int ProfilesId)
        {
            return View();
        }
    }
}
