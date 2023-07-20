using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class LanguageController : Controller
    {
        public ActionResult ChangeLanguage(string lang)
        {
            HttpContext.Session.SetString("lang", lang);
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
