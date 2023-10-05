using core.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using webLoyal.Authorization;

namespace webLoyal.Controllers
{
    public class AuthController : BaseController
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

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index(string error = null)
        {
            //TODO: puedes mandar este error a la vista
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {       
            if (ModelState.IsValid)
            {
                try
                {
                    var ActiveSession = await _loginS.Login(model);
                    if (ActiveSession != null)
                    {
                        string imagenBase64 = ActiveSession.Content.User.UsuarioImagen!=null? Convert.ToBase64String(ActiveSession.Content.User.UsuarioImagen):string.Empty;
                        HttpContext.Session.SetString(nameof(model.UserName), model.UserName);
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.CodigoUsuario), "1");
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.IndicadorValidacion), ActiveSession.Content.User.IndicadorValidacion.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.DireccionEmail), ActiveSession.Content.User.DireccionEmail);
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.NombreCompletoUsuario), ActiveSession.Content.User.NombreCompletoUsuario);
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.CodigoPerfil), ActiveSession.Content.User.CodigoPerfil.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.NombrePerfil), ActiveSession.Content.User.NombrePerfil);
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.IndicadorCorreoVerificado), ActiveSession.Content.User.IndicadorCorreoVerificado.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.IndicadorCambioPassword), ActiveSession.Content.User.IndicadorCambioPassword.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.IndicadorVistaAgentes), ActiveSession.Content.User.IndicadorVistaAgentes.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.CodigoEstadoUsuario), ActiveSession.Content.User.CodigoEstadoUsuario.ToString());
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.User.UsuarioImagen), imagenBase64?? string.Empty);
                        HttpContext.Session.SetString(nameof(ActiveSession.Content.Token), ActiveSession.Content.Token);
                        
                        return Json(new
                        {
                            success = true,
                            title = Resources.language.Resources.UserFound,
                            text = Resources.language.Resources.WelcomeMessage.ToString() + " " + ActiveSession.Content.User.NombreCompletoUsuario.ToString().ToLower(),
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
                //TODO: Revisar
                var ActiveSession = await _loginS.Login(model);

                if (ActiveSession.Content.User.CodigoUsuario > 0)
                {
                    HttpContext.Session.SetString(nameof(model.UserName), model.UserName);
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.User.CodigoUsuario), "1");
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.User.IndicadorValidacion), ActiveSession.Content.User.IndicadorValidacion.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.User.DireccionEmail), ActiveSession.Content.User.DireccionEmail);
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.User.NombreCompletoUsuario), ActiveSession.Content.User.NombreCompletoUsuario);
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.User.CodigoPerfil), ActiveSession.Content.User.CodigoPerfil.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.User.NombrePerfil), ActiveSession.Content.User.NombrePerfil);
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.User.IndicadorCorreoVerificado), ActiveSession.Content.User.IndicadorCorreoVerificado.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.User.IndicadorCambioPassword), ActiveSession.Content.User.IndicadorCambioPassword.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.User.IndicadorVistaAgentes), ActiveSession.Content.User.IndicadorVistaAgentes.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.User.CodigoEstadoUsuario), ActiveSession.Content.User.CodigoEstadoUsuario.ToString());
                    HttpContext.Session.SetString(nameof(ActiveSession.Content.Token), ActiveSession.Content.Token);

                    return Json(new
                    {
                        success = true,
                        title = Resources.language.Resources.UserFound,
                        text = Resources.language.Resources.WelcomeMessage.ToString() + " " + ActiveSession.Content.User.NombreCompletoUsuario.ToString().ToLower(),
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
        
        [HttpGet]
        [Route("Auth/LogOut")]
        public async Task<IActionResult> LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
