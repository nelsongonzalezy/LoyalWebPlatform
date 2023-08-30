using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class PoliciesListViewComponent : ViewComponent
    {
        private readonly IPolicies _request;
        public PoliciesListViewComponent(IPolicies request)
        {
            _request = request;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var x = await _request.GetAll();
            return View(x.ToList());
        }
    }
}
