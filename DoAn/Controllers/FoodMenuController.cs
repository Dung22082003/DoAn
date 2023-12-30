using DoAn.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
	public class FoodMenuController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly DataContext _context;

		public FoodMenuController(ILogger<HomeController> logger, DataContext context)
		{
			_logger = logger;

			_context = context;
		}

		public IActionResult Index()
		{

			var typeFood = (from item in _context.TypeFoods select item).ToList();


			ViewBag.typeFood = typeFood;


			return View(typeFood);
		}

		[Route("/test")]
		[Route("/list-{slug}-{id:int}.html", Name = "List")]
		public IActionResult List(int? id)
		{
			if (id == null)
			{
				return NotFound();

			}
			var list = _context.Menus.Where(m => (m.MenuID == id) && (m.IsActive == true)).Take(6).ToList();
			if (list == null)
			{
				return NotFound();
			}
			return View(list);
		}
		public IActionResult YourAction()
		{
			var typeFood = (from item in _context.TypeFoods select item).ToList();
			ViewBag.typeFood = typeFood;

			ViewData["test"] = typeFood;
			return Ok(typeFood);
		}
	}
}
