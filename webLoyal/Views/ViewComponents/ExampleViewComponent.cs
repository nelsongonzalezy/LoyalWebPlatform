﻿using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Views.ViewComponents
{
    public class ExampleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // Lógica para obtener datos o realizar acciones necesarias
            return View();
        }
    }
}
