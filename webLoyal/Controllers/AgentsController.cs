using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class AgentsController : BaseController
    {
        private readonly IAgents _Agents;

        public AgentsController(IAgents agents)
        {
            _Agents = agents;
        }

        [HttpGet]
        [Route("Agents/Detail/{codigoAgente}")]
        public async Task<IActionResult> Detail(int codigoAgente)
        {
            var model = await _Agents.GetAgentAndwallet(codigoAgente,"99", codigoAgente, "99");
            return View(model);
        }
        [HttpGet]
        [Route("Agents/Index")]
        public async Task<IActionResult> Index()
        {
                var model = await _Agents.GetAll();
            return View(model.ToList());
        }

    }
}
