using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult CofiguredAction(string id, string value1)
		{
			return Content($"Hello world! {id} - {value1}");
		}
	}
}
