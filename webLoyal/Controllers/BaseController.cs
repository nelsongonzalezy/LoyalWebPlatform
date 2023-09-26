namespace webLoyal.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using webLoyal.Authorization;

    [CustomAuthorize]
    public abstract class BaseController : Controller
    {
        public BaseController()
        {

        }
    }
}
