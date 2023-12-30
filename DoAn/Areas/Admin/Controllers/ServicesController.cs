using DoAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            var tmlist = _context.Service.OrderBy(s => s.ServiceID).ToList();
            return View(tmlist);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var tm = _context.Service.Find(id);
            if (tm == null)
            {
                return NotFound();
            }
            return View(tm);

        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var deleService = _context.Service.Find(id);
            if (deleService == null) 
            {
                return NotFound();
            }
            _context.Service.Remove(deleService);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            var tmlist = (from s in _context.Service
                          select new SelectListItem()
                          {
                              Text = s.Title,
                              Value = s.ServiceID.ToString(),
                          }).ToList();
            tmlist.Insert(0, new SelectListItem()
            {
                Text = "----Select----",
                Value = "0"
            });
            ViewBag.tmlist = tmlist;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Services tm)
        {
            if(ModelState.IsValid)
            {
                _context.Service.Add(tm);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }   
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var tm = _context.Service.Find(id);
            if (tm == null)
            {
                return NotFound();
            }
            var tmlist = (from s in _context.Service
                          select new SelectListItem()
                          {
                              Text = s.Title,
                              Value = s.ServiceID.ToString(),
                          }).ToList();
            tmlist.Insert(0, new SelectListItem()
            {
                Text = "----Select----",
                Value = string.Empty
            });
            ViewBag.tmlist = tmlist;
            return View(tm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Services tm)
        {
            if (ModelState.IsValid)
            {
                _context.Service.Update(tm);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tm);
        }
    }
}
