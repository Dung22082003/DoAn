using Microsoft.AspNetCore.Mvc;
using DoAn.Models;

namespace DoAn.Components
{
    [ViewComponent(Name = "ChefView")]
    public class ChefComponent :ViewComponent
    {
        private readonly DataContext _context;
        public ChefComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Chef = (from c in _context.Chefs
                        select c).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", Chef));
        }
    }
}
