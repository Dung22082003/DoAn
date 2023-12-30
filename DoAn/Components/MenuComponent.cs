using DoAn.Models;
using Microsoft.AspNetCore.Mvc;


namespace DoAn.Components
{
    [ViewComponent(Name = "Menu")]
    public class MenuComponent : ViewComponent
    {
        private DataContext _context;
        public MenuComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofMenu = (from m in _context.Menus where (m.IsActive == true) && (m.Position == 1) select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofMenu));
        }
    }
}
