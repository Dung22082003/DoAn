using Microsoft.AspNetCore.Mvc;
using DoAn.Models;
namespace DoAn.Components
{
    [ViewComponent(Name ="BookUs")]
    public class BookUsComponent : ViewComponent
    {
        private readonly DataContext _context;
        public BookUsComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var BookUs = (from h in _context.BookUs
                          select h).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", BookUs));
        }
    }
}
