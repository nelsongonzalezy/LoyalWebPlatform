using core.Service;
using Microsoft.AspNetCore.Mvc;
using System;

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
        public async Task<IActionResult> Create(int CodigoReclamo)
        {
            var model = await _claimsServ.Start(CodigoReclamo);
            model.FechaRegistro=DateTime.Now;
            
            return View(model);
        }   
        [HttpGet]
        [Route("Claims/Get/{id}")]
        public IActionResult Get(int id)
        {
            var model = new ClaimDetailModel();
            return View(model);
        }        
        [HttpGet]
        [Route("Claims/Detail/{CodigoReclamo}")]
        public async Task<IActionResult> Detail(int CodigoReclamo)
        {
            var model= await _claimsServ.GetClaimById(CodigoReclamo);

            return View(model);
        }
        [HttpPost]
        [Route("Claims/Create")]
        public async Task<IActionResult> Create(CreaReclamoInicialModel model)
        {
            try
            {
                model.FechaRegistro = DateTime.Now;
                //var x = await _claimsServ.CreateClaim(model);
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
                        title = "Error al crear la solicitud",
                        message = "Error",
                        type = "error"
                    });

                }
            }
            catch (Exception ex )
            {
                return Json(new
                {
                    success = false,
                    title = "Error al crear la solicitud",
                    message = ex.Message.ToString(),
                    type = "error"
                });
            }
                

            //var x = await _claimsServ.CreateClaim(model);
            //if (true)
            //{
            //    return Json(new
            //    {
            //        success = true,
            //        title = "Reclamo creado con exito",
            //        text = "Gracias",
            //        icon = "success",
            //        timer = 2000
            //    });

            //}
            //else
            //{
               
            //}
        }

        [HttpGet]
        public async Task<IActionResult> GenerateLetterOfGuarantee() 
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GenerateDenialLetter()
        {
            return View();
        }
    }
}
