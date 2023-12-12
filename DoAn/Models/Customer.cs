using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models

{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomersId { get; set; }
        public string? UserName { get; set; }
        public string? Position { get; set; }
        public string? Image { get; set; }
        public bool? IsActive { get; set; }
        public string? Comment { get; set; }
        public string? IconStar { get; set; }
        public string? Iconcomma{ get; set; }
        
    }
}
