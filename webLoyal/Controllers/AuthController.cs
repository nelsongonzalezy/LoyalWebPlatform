using core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Reflection;

namespace webLoyal.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogin _loginS;
        private readonly IStringLocalizer<AuthController> _localizer;
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger, IStringLocalizer<AuthController> localizer, ILogin loginS)
        {
            _logger = logger;
            _localizer = localizer;
            _loginS = loginS;
        }

        [HttpGet]
        [Route("Auth/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Auth/Index")]
        public async Task<IActionResult> Index(LoginModel model)
        {
            
            if (ModelState.IsValid)
            {
                try
                {
                    var ActiveSession = await _loginS.Login(model);
                    if (ActiveSession != null)
                    {
                        HttpContext.Session.SetString(nameof(model.UserName), model.UserName);
                        HttpContext.Session.SetString(nameof(ActiveSession.CodigoUsuario), "1");
                        HttpContext.Session.SetString(nameof(ActiveSession.IndicadorValidacion), ActiveSession.IndicadorValidacion.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.DireccionEmail), ActiveSession.DireccionEmail);
                        HttpContext.Session.SetString(nameof(ActiveSession.NombreCompletoUsuario), ActiveSession.NombreCompletoUsuario);
                        HttpContext.Session.SetString(nameof(ActiveSession.CodigoPerfil), ActiveSession.CodigoPerfil.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.NombrePerfil), ActiveSession.NombrePerfil);
                        HttpContext.Session.SetString(nameof(ActiveSession.IndicadorCorreoVerificado), ActiveSession.IndicadorCorreoVerificado.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.IndicadorCambioPassword), ActiveSession.IndicadorCambioPassword.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.IndicadorVistaAgentes), ActiveSession.IndicadorVistaAgentes.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.CodigoEstadoUsuario), ActiveSession.CodigoEstadoUsuario.ToString());


                        return Json(new
                        {
                            success = true,
                            title = Resources.language.Resources.UserFound,
                            text = Resources.language.Resources.WelcomeMessage.ToString() + " " + ActiveSession.NombreCompletoUsuario.ToString().ToLower(),
                            icon = "success",
                            timer = 2000
                        });
                    }
                    return Json(new
                    {
                        success = false,
                        title = Resources.language.Resources.UserNotFound.ToString(),
                        message = Resources.language.Resources.UserNotFoundMsj,
                        type = "error"
                    });


                }
                catch (Exception x)
                {

                    return Json(new
                    {
                        success = false,
                        title = Resources.language.Resources.UserNotFound.ToString(),
                        message = x.Message.ToString(),
                        type = "error"
                    });
                }
               
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
                    title = Resources.language.Resources.UserFound,
                    message = "La acción se completó con éxito",
                    type = "success"
                });

            }
            return Json(new
            {
                success = false,
                title = Resources.language.Resources.UserNotFound.ToString(),
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
                message = Resources.language.Resources.UserNotFoundMsj,
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

            return !ModelState.IsValid ? Json(new { success = true, title = "success", message = "", Type = "success" }) : View(model);
            //return ModelState.IsValid? Redirect("/auth/index") : View(model);
        }
        [HttpGet]
        [Route("Auth/Reporting")]
        public IActionResult Reporting()
        {
            return View();
        }
        [HttpGet]
        [Route("Auth/FastLock/{email}")]
        public IActionResult FastLock(string userName) 
        {
           var model = new LoginModel { UserName = userName};
            return View(model);
        }
        [HttpPost]
        [Route("Auth/FastSingin")]
        public async Task<IActionResult> FastSingin(string password)
        {
            var model = new LoginModel { UserName = HttpContext.Session.GetString("UserName"),Password=password };

            try
            {
                var ActiveSession = await _loginS.Login(model);

                if (ActiveSession.CodigoUsuario != null)
                {
                    HttpContext.Session.SetString(nameof(model.UserName), model.UserName);
                    HttpContext.Session.SetString(nameof(ActiveSession.CodigoUsuario), "1");
                    HttpContext.Session.SetString(nameof(ActiveSession.IndicadorValidacion), ActiveSession.IndicadorValidacion.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.DireccionEmail), ActiveSession.DireccionEmail);
                    HttpContext.Session.SetString(nameof(ActiveSession.NombreCompletoUsuario), ActiveSession.NombreCompletoUsuario);
                    HttpContext.Session.SetString(nameof(ActiveSession.CodigoPerfil), ActiveSession.CodigoPerfil.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.NombrePerfil), ActiveSession.NombrePerfil);
                    HttpContext.Session.SetString(nameof(ActiveSession.IndicadorCorreoVerificado), ActiveSession.IndicadorCorreoVerificado.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.IndicadorCambioPassword), ActiveSession.IndicadorCambioPassword.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.IndicadorVistaAgentes), ActiveSession.IndicadorVistaAgentes.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.CodigoEstadoUsuario), ActiveSession.CodigoEstadoUsuario.ToString());


                    return Json(new
                    {
                        success = true,
                        title = Resources.language.Resources.UserFound,
                        text = Resources.language.Resources.WelcomeMessage.ToString() + " " + ActiveSession.NombreCompletoUsuario.ToString().ToLower(),
                        icon = "success",
                        timer = 2000
                    });
                }
                return Json(new
                {
                    success = false,
                    title = Resources.language.Resources.UserNotFound.ToString(),
                    message = Resources.language.Resources.UserNotFoundMsj,
                    type = "error"
                });

            }
            catch (Exception)
            {
                return Json(new
                {
                    success = false,
                    title = Resources.language.Resources.UserNotFound.ToString(),
                    message = Resources.language.Resources.UserNotFoundMsj,
                    type = "error"
                });
            }
           




            //if (mail == "test@loyalig.com" && password =="123456") {
            //    return Json(new
            //    {
            //        success = true,
            //        title = Resources.language.Resources.UserFound,
            //        text = Resources.language.Resources.WelcomeMessage.ToString() + " " + mail.ToString().ToLower(),
            //        icon = "success",
            //        timer = 2000
            //    });
            //}
            //else
            //{
            //    return Json(new
            //    {
            //        success = false,
            //        title = Resources.language.Resources.UserNotFound.ToString(),
            //        message = Resources.language.Resources.UserNotFoundMsj,
            //        type = "error"
            //    });
            //}

        }
    }
}
