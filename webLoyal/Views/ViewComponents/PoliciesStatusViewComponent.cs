using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class PoliciesStatusViewComponent : ViewComponent
    {
        private readonly IPolicies _request;
        public PoliciesStatusViewComponent(IPolicies request)
        {
            _request = request;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var x = await _request.GetAllStatus();
            return View(x.ToList());
        }
    }
}
