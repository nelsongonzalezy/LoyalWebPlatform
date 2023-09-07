using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class PoliciesListRenewalViewComponent : ViewComponent
    {
        private readonly IPolicies _request;

        public PoliciesListRenewalViewComponent(IPolicies request) { 
            _request = request;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var x = await _request.GetAllRenewal();
            return View(x.ToList());
        }
    }
}
