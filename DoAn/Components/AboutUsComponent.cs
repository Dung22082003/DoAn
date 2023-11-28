using DoAn.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAn.Components
{
    [ViewComponent(Name = "AboutUsView")]
    public class AboutUsComponent : ViewComponent
    {
        private readonly DataContext _context;
        public AboutUsComponent(DataContext context) { _context = context; }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var aboutUs = _context.AboutUs.Select(au => new
            {
                aboutUs = au,
                services = _context.Services.Where(s => s.about_us_id == au.id).ToList(),
            }).FirstOrDefault();
            return await Task.FromResult((IViewComponentResult)View("Default", aboutUs));
        }
    }

}
