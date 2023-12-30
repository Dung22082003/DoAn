using DoAn.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Controllers
{
    public class AboutController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public AboutController(ILogger<HomeController> logger, DataContext context)
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
