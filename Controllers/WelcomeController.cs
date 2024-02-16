using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
