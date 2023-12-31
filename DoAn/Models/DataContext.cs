using DoAn.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
namespace DoAn.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }



        public DbSet<Menu> Menus { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Services> Service { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<TypeEvent> TypeEvents { get; set; }
        public DbSet<FoodMenu> FoodMenus { get; set; }
        public DbSet<TypeFood> TypeFoods { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AdminMenu> AdminMenus { get; set; } 
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Footer> Footer { get; set; }
      
    }
}