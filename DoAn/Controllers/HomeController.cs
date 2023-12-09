using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DoAn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var typeEvent = (from item in _context.TypeEvents select item).ToList();

            ViewBag.typeEvent = typeEvent;
            return View(typeEvent);
        }

        [Route("/test")]


        public IActionResult YourAction()
        {
            var typeEvent = (from item in _context.TypeEvents select item).ToList();

            ViewBag.typeEvent = typeEvent;
            ViewData["test"] = typeEvent;
            return Ok(typeEvent);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}