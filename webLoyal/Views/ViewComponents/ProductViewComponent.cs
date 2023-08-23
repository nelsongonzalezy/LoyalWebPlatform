using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly IProduct _produc;

        public ProductViewComponent(IProduct produc)
        {
            _produc = produc;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var x =  await _produc.GetProducComponent();
            return View(x.ToList());
        }
    }
}
