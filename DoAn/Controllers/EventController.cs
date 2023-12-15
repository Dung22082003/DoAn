using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
    public class EventController : Controller
    {
        [Route("/Event")]
        public IActionResult Index()
        {
            return View();
        }
    }

}
