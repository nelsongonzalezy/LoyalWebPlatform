using core.Service;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

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
            var model = new CampanaRequestModel { CodigoCampana= CodigoCampana, FechaFin=DateTime.Today, FechaInicio=DateTime.Today, FormaAnual= FormaAnual, FormaMensual= FormaMensual, FormaSemestral= FormaSemestral, FormaTrimestral= FormaTrimestral };
            var x = await _campain.GetCampana(model);
            foreach (var item in x.DtDetalleCampanas) 
            {
                 
                item.FormaAnual = FormaAnual;
                item.FormaSemestral = FormaSemestral;
                item.FormaTrimestral = FormaTrimestral;
                item.FormaMensual = FormaMensual;

            };
            return View(x);
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
