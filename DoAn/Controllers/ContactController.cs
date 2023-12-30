using Microsoft.AspNetCore.Mvc;
using DoAn.Models;
namespace DoAn.Controllers
{
    public class ContactController : Controller

    {
        private readonly DataContext _context;
        public ContactController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contact ct)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(ct);
                _context.SaveChanges();
                TempData["Altermessage"] = "Gửi thành công";
                return RedirectToAction("Index");
            }    
            return View(ct);
        }
    }
}
