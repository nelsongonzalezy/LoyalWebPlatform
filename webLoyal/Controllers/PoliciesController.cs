using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class PoliciesController : BaseController
    {
        private readonly IPolicies _request;
        public PoliciesController(IPolicies request)
        {
            _request = request;
        }
        public async Task<IActionResult> Index()
        {
            var x = await _request.GetAll();
            return View(x.ToList());
        }
        [HttpGet]
        [Route("Policies/Detail/{codigoSolicitud}")]
        public async Task<IActionResult> Detail(int codigoSolicitud) 
        { 
            var model = await _request.GetByCode(codigoSolicitud);
            return View(model); 
        }

        public async Task<IActionResult> Renewal()
        {
            var x = await _request.GetFiguresRenewal();
            return View(x.ToList());
        }

        public IActionResult Cancellation()
        {
            return PartialView("_Cancellation");
        }        
        public IActionResult ChangeOfPlan()
        {
            return PartialView("_Cancellation");
        }        
        public IActionResult Modification()
        {
            return PartialView("_Cancellation");
        }        
        public IActionResult RecordNote()
        {
            return PartialView("_Cancellation");
        }        
        public IActionResult ModifyTaker()
        {
            return PartialView("_Cancellation");
        }        
        public IActionResult AddDocuments()
        {
            return PartialView("_Cancellation");
        }
        public IActionResult RecodeAgent()
        {
            return PartialView("_RecodeAgent");
        }
        [HttpPost]
        public IActionResult RecodeAgent(RecodeAgentModel model)
        {
            return PartialView("_RecodeAgent");
        }
    }
}
