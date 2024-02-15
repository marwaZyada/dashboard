using Dashboard.Contexts;
using Dashboard.Data;
using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DashboardContext context;

        public HomeController(ILogger<HomeController> logger,DashboardContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public ActionResult Index()
        {
            var auths = (from a in context.AuthPages
                         where a.ParentId == null
                         select a
                      ).ToList();
            return View(auths);
        }


        public ActionResult ViewName(int id)
        {
            var dataforeachauth = (from a in context.AuthPages
                                   where a.ParentId == id
                                   select a

                                 );

            return Json(dataforeachauth);

        }

        public ActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
