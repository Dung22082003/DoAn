using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
    public class FoodMenuController : Controller
    {
        [Route("/FoodMenu")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
