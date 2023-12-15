using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
    public class ServicesController : Controller
    {

        [Route("/Services")]
        public IActionResult Index()
        {
            return View();
        }
 
        
    }
}

