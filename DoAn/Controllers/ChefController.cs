using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
	public class ChefController : Controller
	{
		[Route("/ChefView")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
