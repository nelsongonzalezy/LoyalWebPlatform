using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        [Route("Profile/edit/{UserCode}")]
        public IActionResult edit(string UserCode)
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
 