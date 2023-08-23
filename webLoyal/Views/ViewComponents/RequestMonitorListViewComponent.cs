using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class RequestMonitorListViewComponent : ViewComponent
    {
        private readonly IRequestMonitor _requestMonitor;
        public RequestMonitorListViewComponent(IRequestMonitor requestMonitor)
        {
            _requestMonitor = requestMonitor;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var x = await _requestMonitor.GetAlList();
            return View(x.ToList());
        }
    }
}
