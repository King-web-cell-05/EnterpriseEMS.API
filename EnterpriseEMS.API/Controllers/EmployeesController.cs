using Microsoft.AspNetCore.Mvc;

namespace EnterpriseEMS.API.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
