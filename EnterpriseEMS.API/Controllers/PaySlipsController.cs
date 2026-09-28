using Microsoft.AspNetCore.Mvc;

namespace EnterpriseEMS.API.Controllers
{
    public class PaySlipsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
