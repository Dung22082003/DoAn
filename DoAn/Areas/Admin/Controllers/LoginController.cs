using DoAn.Areas.Admin.Models;
using DoAn.Models;
using DoAn.Ultilities;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/login")]
    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }

        // Action mặc định để hiển thị trang đăng nhập
        [HttpGet]
        public IActionResult Index()
        {
            // Lưu trữ URL tham chiếu trong TempData
            TempData["Referrer"] = Request.Headers["Referer"].ToString();
            return View();
        }

        // Action xử lý đăng nhập khi nhận yêu cầu POST từ form đăng nhập
        [HttpPost]
        [Route("index")]
        public IActionResult Index([FromBody] AdminUser user)
        {
            if (user == null)
            {
                return NotFound();
            }

            // Mã hóa mật khẩu trước khi kiểm tra
            string hashedPassword = Functions.MD5Password(user.Password);
            user.Password = hashedPassword;

            // Kiểm tra sự tồn tại của người dùng với email và mật khẩu đã mã hóa
            var check = _context.AdminUsers
                .Where(m => m.Email == user.Email && m.Password == hashedPassword)
                .FirstOrDefault();

            if (check == null)
            {
                return BadRequest(new
                {
                    err = "Sai tên đăng nhập hoặc mật khẩu!",
                });
            }

            Functions._Message = string.Empty;

            Functions._UserID = check.UserID;
            Functions._UserName = string.IsNullOrEmpty(check.UserName) ? string.Empty : check.UserName;
            Functions._Email = string.IsNullOrEmpty(check.Email) ? string.Empty : check.Email;

            // Nếu không có URL tham chiếu hoặc URL không hợp lệ, chuyển hướng đến trang mặc định
            return Ok();
        }
    }
}
