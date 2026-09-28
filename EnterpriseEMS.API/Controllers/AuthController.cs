using Microsoft.AspNetCore.Mvc;

namespace EnterpriseEMS.API.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
