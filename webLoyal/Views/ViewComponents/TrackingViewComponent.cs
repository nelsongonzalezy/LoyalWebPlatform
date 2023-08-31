using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class TrackingViewComponent : ViewComponent
    {
        private readonly IRequestMonitor _requestMonitor;

        public TrackingViewComponent(IRequestMonitor requestMonitor)
        {
            _requestMonitor = requestMonitor;
        }
        public async Task<IViewComponentResult> InvokeAsync(string CodigoSolicitud)
        {
            var x = await _requestMonitor.GetTaskByID(CodigoSolicitud);
            return View(x.ToList());
        }
    }
}
