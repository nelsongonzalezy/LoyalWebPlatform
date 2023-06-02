using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class ClaimsController : Controller
    {
        private readonly IClaimsServ _claimsServ;

        public ClaimsController(IClaimsServ claimsServ)
        {
            _claimsServ = claimsServ;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _claimsServ.GetAll();

            return View(model.ToList());
        }       
        [HttpGet]
        public IActionResult Create()
        {
            var model = new ClaimCreateModel();
            model.ClaimId = 32;
            model.ClaimDate = DateTime.Now;
            return View(model);
        }   
        [HttpGet]
       
        public IActionResult Get(int id)
        {
            var model = new ClaimDetailModel();
            return View(model);
        }
        [HttpPost]
        [Route("Claims/Create")]
        public async Task<IActionResult> Create(ClaimCreateModel model)
        {
            if (true)
            {
                return Json(new
                {
                    success = true,
                    title = "Reclamo creado con exito",
                    text = "Gracias",
                    icon = "success",
                    timer = 2000
                });

            }
            else
            {
                return Json(new
                {
                    success = false,
                    title = "Usuario o contraseña invalida",
                    message = "lo sentimos no hemos logrado validar sus credenciales",
                    type = "error"
                });
            }
        }
    }
}
