using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class LivesController : BaseController
    {
        private readonly ILives _Lives;

        public LivesController(ILives Lives)
        {
            _Lives = Lives;
        }

        public async Task<IActionResult> Index()
        {
            var x = await _Lives.GetAllLife();
            return View(x.ToList());
        }
    }
}
