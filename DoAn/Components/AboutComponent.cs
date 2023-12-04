using Microsoft.AspNetCore.Mvc;
using DoAn.Models;
namespace DoAn.Components
{
    [ViewComponent(Name = "About")]
    public class AboutComponent : ViewComponent
    {
        private readonly DataContext _context;
        public AboutComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofAbout = (from a in _context.Abouts
                              select a).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofAbout));
        }
    }
}
//jbjbjb