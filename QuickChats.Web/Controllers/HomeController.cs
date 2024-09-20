using Bogus;
using Microsoft.AspNetCore.Mvc;

namespace QuickChats.Web.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

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
