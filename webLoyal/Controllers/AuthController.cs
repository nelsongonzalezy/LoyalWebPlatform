using core.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

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
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {       
            var ActiveSession = await _loginS.Login(model);

            HttpContext.Session.SetString(nameof(model.UserName), model.UserName);
            HttpContext.Session.SetString(nameof(ActiveSession.UserCode), "1");
            HttpContext.Session.SetString(nameof(ActiveSession.IndicatorCode), ActiveSession.IndicatorCode.ToString());
            HttpContext.Session.SetString(nameof(ActiveSession.AddressEmail), ActiveSession.AddressEmail);
            HttpContext.Session.SetString(nameof(ActiveSession.FullNameUser), ActiveSession.FullNameUser);
            HttpContext.Session.SetString(nameof(ActiveSession.CodeProfile), ActiveSession.CodeProfile.ToString());
            HttpContext.Session.SetString(nameof(ActiveSession.NameProfile), ActiveSession.NameProfile);
            HttpContext.Session.SetString(nameof(ActiveSession.UserProfile), ActiveSession.UserProfile);
            HttpContext.Session.SetString(nameof(ActiveSession.PasswordEmail), ActiveSession.PasswordEmail);
            HttpContext.Session.SetString(nameof(ActiveSession.AddressEmail), ActiveSession.AddressEmail);
            HttpContext.Session.SetString(nameof(ActiveSession.IndicatorMailVerified), ActiveSession.IndicatorMailVerified.ToString());
            HttpContext.Session.SetString(nameof(ActiveSession.IndicatorChangePassword), ActiveSession.IndicatorChangePassword.ToString());
            HttpContext.Session.SetString(nameof(ActiveSession.IndicatorViewAgents), ActiveSession.IndicatorViewAgents.ToString());
            HttpContext.Session.SetString(nameof(ActiveSession.CodeStateUser), ActiveSession.CodeStateUser.ToString());              

            return Json(new
            {   
                success = true,
                title = Resources.language.Resources.UserFound,
                text = Resources.language.Resources.WelcomeMessage.ToString() + " " + model.UserName.ToString().ToLower(),
                icon = "success",
                timer = 2000
            });        
        }

        [HttpGet]
        public IActionResult Recover()
        {
            return View();
        }

        [HttpPost]
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
        public IActionResult ValidUser()
        {
            var xnew = new IsValidModel();
            return View(xnew);

        }

        [HttpGet]
        public IActionResult IsValidUser()
        {
            return View();
        }

        [HttpPost]
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
        public IActionResult ChangePassword(ChangePasswordModel model)
        {

            return !ModelState.IsValid ? Json(new { success = true, title = "success", message = "", Type = "success" }) : View(model);
            //return ModelState.IsValid? Redirect("/auth/index") : View(model);
        }

        [HttpGet]
        public IActionResult Reporting()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FastLock(string userName) 
        {
           var model = new LoginModel { UserName = userName};
            return View(model);
        }

        [HttpPost]
        public IActionResult FastSingin(string password)
        {

            var mail = HttpContext.Session.GetString("Email");
            if (mail == "test@loyalig.com" && password =="123456") {
                return Json(new
                {
                    success = true,
                    title = Resources.language.Resources.UserFound,
                    text = Resources.language.Resources.WelcomeMessage.ToString() + " " + mail.ToString().ToLower(),
                    icon = "success",
                    timer = 2000
                });
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
    }
}
