using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class CampaignController : BaseController
    {
        private readonly ICampanig _campain;

        public CampaignController(ICampanig campanig)
        {
            _campain = campanig;
        }
        //public async Task<IActionResult> Index(int CodigoCampana)
        [Route("/campaign/index")]
        public async Task<IActionResult> Index(int CodigoCampana, bool FormaAnual, bool FormaSemestral, bool FormaTrimestral, bool FormaMensual, DateTime FechaInicio, DateTime FechaFin)
        {

            //FechaFin = FechaFin==null? DateTime.Now: FechaFin;
            //FechaInicio = FechaInicio == null? DateTime.Now: FechaInicio;

            var model = new CampanaRequestModel { CodigoCampana= CodigoCampana, FechaFin= DateTime.Now, FechaInicio= DateTime.Now, FormaAnual= FormaAnual, FormaMensual= FormaMensual, FormaSemestral= FormaSemestral, FormaTrimestral= FormaTrimestral };
            var x = await _campain.GetCampana(model);
            foreach (var item in x.DtDetalleCampanas) 
            {
                item.FormaAnual = FormaAnual;
                item.FormaSemestral = FormaSemestral;
                item.FormaTrimestral = FormaTrimestral;
                item.FormaMensual = FormaMensual;
            };
            //x.DtCampanas.FechaFin = FechaFin;
            //x.DtCampanas.FechaInicio = FechaInicio;
            FechaFin = x.DtCampanas.FechaFin ;
            FechaInicio=x.DtCampanas.FechaInicio;

            DateTime fechaFutura = FechaFin; // Define tu fecha futura aquí

            TimeSpan diferencia = fechaFutura - DateTime.Now;
            if (diferencia.Days <0)
            {
                x.mensaje = string.Format("Culmino la campaña ");
            }
            else
            {
                x.mensaje = string.Format("Faltan {0} días {1} horas {2} minutos",
                diferencia.Days, diferencia.Hours, diferencia.Minutes);

            }
 

            return View(x);
        }        
        [Route("/campaign/List")]
        public async Task<IActionResult> List()
        {
            var model = await _campain.GetListCampana();

            return View(model.ToList());
        }        
        [Route("/campaign/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/campaign/Create")]
        public async Task<IActionResult> Create(CreateCampaignModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _campain.CreateCampana(model))
                    {
                        return Json(new
                        {
                            success = true,
                            title = "Campaña creado con exito",
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
                }else 
                {
                    return Json(new
                    {
                        success = false,
                        title = "Debe validar los campos",
                        message = "Error",
                        type = "error"
                    });
                }

            }
            catch (Exception ex)
            {
                return Json(new
                {
                    success = false,
                    title = "Error al crear la solicitud",
                    message = ex.Message.ToString(),
                    type = "error"
                });
            }
        }
        //[HttpGet]
        //[Route("/campaign/index2?CodigoCampana={$CodigoCampana}&FormaAnual=1&FormaSemestral=1&FormaTrimestral=1&FormaMensual=1&FechaInicio=2023-09-05&FechaInicio=2023-09-28")]
        //public async Task<IActionResult> Index2(int CodigoCampana, DateOnly? FechaFin, DateOnly? FechaInicio,bool? FormaAnual,bool? FormaMensual,bool? FormaSemestral,bool FormaTrimestral)
        //{
        //    var model = new CampanaRequestModel { CodigoCampana= CodigoCampana, FechaFin=DateTime.Today, FechaInicio=DateTime.Today, FormaAnual=true,FormaMensual=false,FormaSemestral=false,FormaTrimestral=false};
        //    var x = await _campain.GetCampana(model);
        //    return View(x);
        //}
     
    }
}
