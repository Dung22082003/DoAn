using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
	public class AboutUsController : Controller
	{
		[Route("/AboutUsView")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
