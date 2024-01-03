using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    [ViewComponent(Name = "MyModal")]
    public class MyModalViewComponent :ViewComponent
    {   
        public IViewComponentResult Invoke()
        {
            var model = new MyViewModel
            {
                Parametro1 = 11
         
                // Otros datos que quieras pasar al modal
            };

            return View(model);
        }
    }
}
