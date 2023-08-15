using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class PoliciesController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<PoliciesDetailModel>();
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0001", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0002", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0003", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0004", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0005", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0006", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0007", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0008", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0009", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0010", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new PoliciesDetailModel { PolicyNumber = "000-000-0011", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto", EffectiveEndDate = DateTime.Now.ToString() });

            return View(model);
        }

        public IActionResult Detail() { return View(); }

    }
}
