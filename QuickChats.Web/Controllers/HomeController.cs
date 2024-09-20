using Bogus;
using Microsoft.AspNetCore.Mvc;

namespace QuickChats.Web.Controllers;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

	[HttpGet]
	[Route("/Home/GetNewRandomName")]
	public IActionResult GetNewRandomName() => 
		Json(new { Name = new Faker().Name.FirstName() });
		
	
	public IActionResult Chat()
	{
		return View();
	}
}
