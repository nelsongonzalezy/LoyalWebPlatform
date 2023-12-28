using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class CommissionController : BaseController
    {
        private readonly ICommission _Serv;

        public CommissionController(ICommission Serv)
        {
            _Serv = Serv;
        }
        [Route("/commission/index/{CodigoCicloComisiones}")]
        public async Task<IActionResult> Index(int CodigoCicloComisiones)
        {

            var model = await _Serv.GetCommissio(CodigoCicloComisiones);

            return View(model);
        }
        [Route("/commission/Detail/")]
        public async Task<IActionResult> Detail(int CodigoCicloComisiones, int CodigoAgente)
        {

            var model = await _Serv.GetCommissio(CodigoCicloComisiones);
            return Json(model.DetalleCicloComisionesAgente.Where(x => x.CodigoCicloComisiones == CodigoCicloComisiones && x.CodigoAgente== CodigoAgente)
            .Select(x => new
            {
                x.CodigoAgente,
                x.NombreAgente,
                x.NumeroPoliza,
                x.TitularPoliza,
                x.PrimaAnual,
                x.PrimaNeta,
                x.CostoAdministrativo,
                x.PrimaComisionable,
                x.PorcentajeComision,
                x.MontoComision,
                x.FormaPago
            }));
        }
        public IActionResult Cancellation()
        {
            return PartialView("_Cancellation");

        }
    }
}
