using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class RequestsViewComponent : ViewComponent
    {
        private readonly IRequestMonitor _requestMonitor;

        public RequestsViewComponent(IRequestMonitor requestMonitor)
        {
            _requestMonitor = requestMonitor;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var x = await _requestMonitor.GetAllStatus(); 
            return View(x.ToList());
        }
    }
}
