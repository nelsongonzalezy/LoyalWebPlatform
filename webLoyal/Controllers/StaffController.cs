using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class StaffController : BaseController
    {
        private readonly IStaff _staff;

        public StaffController(IStaff staff)
        {
            _staff = staff;
        }
        public async Task<IActionResult> Index()
        {
            var x = await _staff.GetDetailsStaff();
            return View(x);
        }
    }
}
