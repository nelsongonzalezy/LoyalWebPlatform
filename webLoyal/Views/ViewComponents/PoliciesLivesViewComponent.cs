using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class PoliciesLivesViewComponent : ViewComponent
    {
        private readonly ILives _request;
        public PoliciesLivesViewComponent(ILives request)
        {
            _request = request;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var x = await _request.GetAllCountLife();
            return View(x.ToList());
        }
    }
}
