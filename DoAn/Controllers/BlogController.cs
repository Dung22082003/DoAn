using DoAn.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
	public class BlogController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly DataContext _context;

		public BlogController(ILogger<HomeController> logger, DataContext context)
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
