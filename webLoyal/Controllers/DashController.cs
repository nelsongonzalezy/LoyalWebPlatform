using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class DashController : Controller
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
    }
}
