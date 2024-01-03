using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class PoliciesLivesListViewComponent : ViewComponent
    {
        private readonly ILives _request;
        public PoliciesLivesListViewComponent(ILives request)
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
