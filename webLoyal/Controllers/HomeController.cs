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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetBoard()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> InConstruction()
        {
            return View();
        }        

        [HttpGet]
        public IActionResult Notfound()
        {
            return View();
        }        

        [HttpGet]
        public async Task<IActionResult> InternalServerError()
        {
            return View();
        }        

        [HttpGet]
        public async Task<IActionResult> ServicesUnaiviable()
        {
            return View();
        }       

        [HttpGet]
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