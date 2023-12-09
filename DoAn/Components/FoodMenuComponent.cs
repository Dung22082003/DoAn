using Microsoft.AspNetCore.Mvc;
using DoAn.Models;

namespace DoAn.Components
{
    [ViewComponent( Name = "FoodMenuView")]
    public class FoodMenuComponent : ViewComponent

    {
        private readonly DataContext _context;
        public FoodMenuComponent(DataContext context )
        {
            _context = context;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        
            {
                var FoodMenu  = (from f in _context.FoodMenus
                                 select f).ToList();
                return await Task.FromResult((IViewComponentResult)View("Default", FoodMenu));
            } 
    }
}
