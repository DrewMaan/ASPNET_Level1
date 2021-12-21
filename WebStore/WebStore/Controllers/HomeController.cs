using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
	public class HomeController : Controller
	{
		private static readonly List<Employee> _employees = new List<Employee>
		{
			new Employee { Id = 1, LastName = "Ivanov", FirstName = "Ivan", Patronymic = "Ivanovich", Age = 30, 
							Department = "HR department", Position = "HR BP", StartDate = new DateTime(2020, 10, 23)},
			new Employee { Id = 2, LastName = "Petrov", FirstName = "Petr", Patronymic = "Petrovich", Age = 45,
							Department = "Accounting department", Position = "Accountant", StartDate = new DateTime(2019, 12, 10)},
			new Employee { Id = 3, LastName = "Sidorov", FirstName = "Sidor", Patronymic = "Sidorovich", Age = 24,
							Department = "Developing department", Position = "Developer", StartDate = new DateTime(2021, 05, 23)}
		};

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult CofiguredAction(string id, string value1)
		{
			return Content($"Hello world! {id} - {value1}");
		}

		public IActionResult Employees()
		{
			return View(_employees);
		}

		public IActionResult Employee(int id)
		{
			return View(_employees.FirstOrDefault(x => x.Id == id));
		}
	}
}
