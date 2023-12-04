using Microsoft.EntityFrameworkCore;
namespace DoAn.Models
{
    public class DataContext : DbContext
    {
      public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
         
    public DbSet<Menu> Menus {  get; set; }
    public DbSet<AboutUs> AboutUs {  get; set; }
    public DbSet<Service> Services {  get; set; }
    public DbSet<About> Abouts { get; set; }
    }
}