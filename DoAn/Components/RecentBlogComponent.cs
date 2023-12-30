using Microsoft.AspNetCore.Mvc;
using DoAn.Models;
namespace DoAn.Components
{
    [ViewComponent(Name = "RencentBlog")]
    public class RecentBlogComponent: ViewComponent
    {
        private readonly DataContext _context;
        public RecentBlogComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Blog = (from b in _context.Blogs
                        where (b.IsActive == true) && (b.Status ==1)
                        orderby b.BlogId descending
                        select b).Take(6).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", Blog));
        }

    }
}
