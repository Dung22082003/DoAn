using DoAn.Models;
using DoAn.Ultilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoAn.Controllers
{
    public class BookUsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public BookUsController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "Login");

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "Login");
            var mnList = (from m in _context.BookUs
                          select new SelectListItem()
                          {
                              Text = m.Name,
                              Value = m.BookID.ToString(),
                          }).ToList();
            mnList.Insert(0, new SelectListItem()
            {
                Text = "----Select----",
                Value = "0"
            });
            ViewBag.mnList = mnList;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookUs bk)
        {
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "Login");
            if (ModelState.IsValid)
            {
                _logger.LogInformation($"Book Name: {bk.Name}, Email: {bk.Email}, DT: {bk.PhoneNumber}, People: {bk.AmountOfPeople}, Note: {bk.Note}");

                _context.BookUs.Add(bk);
                _context.SaveChanges();

                // Lưu thông báo vào TempData để chuyển sang action khác
                TempData["SuccessMessage"] = "Đặt bàn thành công!";

                return RedirectToAction("Index");
            }
            else
            {
                // Log lỗi ModelState
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        _logger.LogError($"ModelState Error: {error.ErrorMessage}");
                    }
                }
            }
            return View(bk);
        }
    }
}
