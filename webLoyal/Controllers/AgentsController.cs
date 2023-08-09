using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class AgentsController : Controller
    {
    
    [HttpGet]
    [Route("Agents/Detail")]
    public IActionResult Detail()
    {
        return View();
    }
    }
}
