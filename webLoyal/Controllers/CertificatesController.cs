using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class CertificatesController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<CertificatesDetailModel>();
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0001", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0002", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0003", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0004", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0005", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0006", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0007", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0008", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0009", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0010", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });
            model.Add(new CertificatesDetailModel { PolicyNumber = "000-000-0011", EffectiveStartDate = "2022-01-01", PlanCode = "Liberty", CódigoTipoVenta = "Abierto",  EffectiveEndDate = DateTime.Now.ToString() });

            return View(model);
        }
    }
}
