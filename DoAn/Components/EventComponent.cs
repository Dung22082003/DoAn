using Microsoft.AspNetCore.Mvc;
using DoAn.Models;
using Microsoft.EntityFrameworkCore;

namespace DoAn.Components
{
    [ViewComponent(Name = "EventView")]
    public class EventComponent : ViewComponent
    {
        private readonly DataContext _context;
        public EventComponent (DataContext context)
        {
            _context = context; 
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Event = (from e in _context.Events
                         select e).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", Event));

        }
    }
}
