using Microsoft.AspNetCore.Mvc;

namespace EnterpriseEMS.API.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
