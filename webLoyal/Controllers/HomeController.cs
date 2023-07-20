using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using webLoyal.Models;

namespace webLoyal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/home/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        [Route("/home/GetBoard")]
        public async Task<IActionResult> GetBoard()
        {
            return View();
        }
        [HttpGet]
        [Route("/home/InConstruction")]
        public async Task<IActionResult> InConstruction()
        {
            return View();
        }        
        [HttpGet]
        [Route("/home/notfound")]
        public IActionResult Notfound()
        {
            return View();
        }        
        [HttpGet]
        [Route("/home/Internalservererror")]
        public async Task<IActionResult> InternalServerError()
        {
            return View();
        }        
        [HttpGet]
        [Route("/home/ServicesUnaiviable")]
        public async Task<IActionResult> ServicesUnaiviable()
        {
            return View();
        }       
        [HttpGet]
        [Route("/home/Forbidden")]
        public async Task<IActionResult> Forbidden()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}