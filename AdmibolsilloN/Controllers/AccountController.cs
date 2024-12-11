using Microsoft.AspNetCore.Mvc;

namespace AdmibolsilloN.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult AdminDashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdvisorDashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ClientDashboard()
        {
            return View();
        }
    }
}

