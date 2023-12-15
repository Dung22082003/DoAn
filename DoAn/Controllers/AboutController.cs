using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
	public class AboutController : Controller
	{
		[Route("/About")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
