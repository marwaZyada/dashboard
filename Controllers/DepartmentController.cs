using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
	public class DepartmentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
