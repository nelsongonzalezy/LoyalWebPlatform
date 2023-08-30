using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class PoliciesProductViewComponent : ViewComponent
    {
        private readonly IPolicies _request;
        public PoliciesProductViewComponent(IPolicies request)
        {
            _request = request;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var x = await _request.GetAllProduct();
            return View(x.ToList());
        }
    }
}
