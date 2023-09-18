using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class CampaignController : Controller
    {
        private readonly ICampanig _campain;

        public CampaignController(ICampanig campanig)
        {
            _campain = campanig;
        }
        public async Task<IActionResult> Index(int CodigoCampana)
        {
            var model = new CampanaRequestModel { CodigoCampana= CodigoCampana, FechaFin=DateTime.Today, FechaInicio=DateTime.Today, FormaAnual=true,FormaMensual=false,FormaSemestral=false,FormaTrimestral=false};
            var x = await _campain.GetCampana(model);
            return View(x);
        }
    }
}
