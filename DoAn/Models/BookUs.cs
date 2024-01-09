using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models
{
    [Table("BookUS")]
    public class BookUs
    {
        [Key]
        public int BookID { get; set; }
        public string? Name { get; set; }
        public string? EventType { get; set; }
        public string? Address {  get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? AmountOfPeople { get; set; }
        public string? Note { get; set; }
    }
}
