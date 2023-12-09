using Microsoft.AspNetCore.Mvc;
using DoAn.Models;
namespace DoAn.Components
{
    [ViewComponent(Name = "ServicesView")]
    public class ServicesComponent : ViewComponent
    {
        private readonly DataContext _context;
        public ServicesComponent (DataContext context)
        {
            _context = context;
        }
        public async  Task<IViewComponentResult> InvokeAsync()
        {
            var listofServices = (from s in _context.Service
                                  select s).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofServices));
        }
        
    }
}
