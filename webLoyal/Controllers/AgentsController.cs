using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class AgentsController : Controller
    {
    
    [HttpGet]
    [Route("Agents/Detail/{codigoAgente}")]
    public IActionResult Detail(int codigoAgente)
    {
        return View();
    }
    }
}
