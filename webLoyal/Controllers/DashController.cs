using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class DashController : BaseController
    {
        private readonly IBoardService _IBoardService;
        public DashController(IBoardService IBoardService) { _IBoardService = IBoardService; }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BoardAgents() 
        {
            var ret = await _IBoardService.GetBoardAgents();
            return View(ret.ToList());
        }
        public async Task<IActionResult> GetAllAgents()
        {
            return View();
        }        
        public async Task<IActionResult> GetAllAgencies()
        {
            return View();
        }        
        public async Task<IActionResult> GetAllMaster()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> MiVistaParcial()
        {
            var model = await _IBoardService.GetSales(0, 0);
            //List<VentasTotalesModel> ventasTotales = model.VentasTotales.ToList();

            //List<VentasPorAnioModel> ventasAgrupadas = ventasTotales
            //    .GroupBy(v => v.AnioFechaCobro)
            //    .Select(g => new VentasPorAnioModel
            //    {
            //        Anio = g.Key,
            //        Ventas = g.Select(v => new VentaModel
            //        {
            //            Mes = v.MesFechaCobro,
            //            Total = v.ValorCuota
            //        }).ToList()
            //    })
            //    .ToList();


            return PartialView("_MiVistaParcial", model.VentasTotales);
        }
    }
}
