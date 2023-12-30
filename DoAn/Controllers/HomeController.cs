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
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("/blog-{slug}-{id:long}.html", Name ="Details")]
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var blog = _context.Blogs
                .FirstOrDefault(m => (m.BlogId == id) && (m.IsActive == true));
            if (blog == null)
            {
                return NotFound();

            }   
            return View(blog);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}