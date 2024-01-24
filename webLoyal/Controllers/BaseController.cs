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

        public ActionResult BaseResult(bool success)
        {
            if (success) {
                return Json(new
                {
                    success = true,
                    title = Resources.language.Resources.Success,
                    text = Resources.language.Resources.SuccessMsj.ToString(),
                    icon = "success"
                });
            }
            else {
                return Json(new
                {
                    success = false,
                    title = Resources.language.Resources.InternalServerErrorMsj.ToString(),
                    message = Resources.language.Resources.InternalServerErrorMsj,
                    icon = "error"
                });
            }
        }
    }
}
