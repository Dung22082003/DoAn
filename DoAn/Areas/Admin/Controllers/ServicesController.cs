using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace DoAn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private readonly DataContext _context;
        public ServicesController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var tmlist = _context.Service.OrderBy(s =>  s.ServiceID).ToList();
            return View(tmlist);
        }

    }
}
