using core.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Reflection;

namespace webLoyal.Controllers
{
    public class AuthController : Controller
    {
        private readonly IStringLocalizer<AuthController> _localizer;
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger, IStringLocalizer<AuthController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }
        [HttpGet]
        [Route("Auth/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Auth/Index")]
        public IActionResult Index(LoginModel model)
        {   

            if (model.Password=="123456")
            {
                return Json(new
                {
                    success = true,
                    title = Resources.language.Resources.UserFound,
                    text = Resources.language.Resources.WelcomeMessage.ToString()+" "+model.Email.ToString().ToLower(),
                    icon = "success",
                    timer = 2000
                }) ;

            }
            else
            {
                return Json(new
                {
                    success = false,
                    title = Resources.language.Resources.UserNotFound.ToString(),
                    message = Resources.language.Resources.UserNotFoundMsj,
                    type = "error"
                });
            }

            
           
        }

        [HttpGet]
        [Route("Auth/Recover")]
        public IActionResult Recover()
        {
            return View();       
        }

        [HttpPost]
        [Route("Auth/Recover")]
        public IActionResult Recover(RecoverModel model)
        {
            if (model.Email == "nelson.gonzalez@grupokaizen.net")
            {
                return Json(new
                {
                    success = true,
                    title = "Usuario encontrado",
                    message = "La acción se completó con éxito",
                    type = "success"
                });

            }
            return Json(new
            {
                success = false,
                title = "Usuario no encontrado",
                message = "La acción se completó con éxito",
                type = "error"
            });
        }
        [HttpPost]
        [Route("Auth/ValidUser")]
        public IActionResult ValidUser(RecoverModel model)
        {
            if (model.Email == "nelson.gonzalez@grupokaizen.net")
            {
                return Json(new {
                    success = true,
                    title = Resources.language.Resources.UserFound,
                    message = "La acción se completó con éxito",
                    type = "success"
                });

            }
            return Json(new
            {
                success = false,
                title = Resources.language.Resources.UserNotFound,
                message = "La acción se completó con éxito",
                type = "error"
            });
            
        }

        [HttpGet]
        [Route("Auth/ValidUser")]
        public IActionResult ValidUser()
        {
            var xnew = new IsValidModel();
            return View(xnew);

        }

        [HttpGet]
        [Route("Auth/IsValidUser")]
        public IActionResult IsValidUser()
        {
            return View();
        }

        [HttpPost]
        [Route("Auth/IsValidUser")]
        public IActionResult IsValidUser(IsValidModel model)
        {
            try
            {
                // Procesa la acción
                // ...

                return Json(new
                {
                    success = true,
                    title = "true",
                    message = "La acción se completó con éxito",
                    type = "success"
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    success = false,
                    title = "Error",
                    message = ex.Message,
                    type = "error"
                });
            }
        }        
        [HttpPost]
        [Route("Auth/ChangePassword")]
        public IActionResult ChangePassword(ChangePasswordModel model)
        {

            return !ModelState.IsValid ? Json(new { success=true,title="success",message="",Type="success"}) : View(model);
            //return ModelState.IsValid? Redirect("/auth/index") : View(model);
        }
        [HttpGet]
        [Route("Auth/Reporting")]
        public IActionResult Reporting()
        {
            return View();
        }

    }
}
