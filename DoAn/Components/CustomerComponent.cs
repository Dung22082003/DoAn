using Microsoft.AspNetCore.Mvc;
using DoAn.Models;
namespace DoAn.Components
{
    [ViewComponent(Name = "CustomerView")]
    public class CustomerCompnent : ViewComponent

    {
        private readonly DataContext _context;
        public CustomerCompnent(DataContext context)
        {
            _context = context;
        }
         public async Task<IViewComponentResult> InvokeAsync()
        {
            var Customer = (from t in _context.Customers
                            select t).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", Customer));
        }
    }
}
