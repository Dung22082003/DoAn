using DoAn.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
	public class ChefController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly DataContext _context;

		public ChefController(ILogger<HomeController> logger, DataContext context)
		{
			_logger = logger;

			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
