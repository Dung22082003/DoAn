using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoAn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookUsController : Controller
    {
        private readonly DataContext _context;
        public BookUsController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var hilist = _context.BookUs.OrderBy(m => m.BookID).ToList();
            return View(hilist);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var mn = _context.BookUs.Find(id);
            if (mn == null)
            {
                return NotFound();
            }
            return View(mn);
        }
		[HttpGet]
		[Route("/Admin/BookUs/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var deleBookUs = _context.BookUs.Find(id);
            if (deleBookUs == null)
            {
                return NotFound();
            }
            _context.BookUs.Remove(deleBookUs);
            _context.SaveChanges();
            return RedirectToAction("index", "bookus");
        }
    }

}
