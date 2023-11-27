using Microsoft.AspNetCore.Mvc;
using DoAn.Models;
namespace DoAn.Components
{
    [ViewComponent(Name = "Home")]
    public class HomeComponent : ViewComponent
    {
        private readonly DataContext _context;
        public HomeComponent(DataContext context)
        { 
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofHome = (from h in _context.Homes
                               select h).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofHome));
        }
    }
}
