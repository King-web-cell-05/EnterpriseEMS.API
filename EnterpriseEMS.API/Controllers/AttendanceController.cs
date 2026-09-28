using Microsoft.AspNetCore.Mvc;

namespace EnterpriseEMS.API.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
