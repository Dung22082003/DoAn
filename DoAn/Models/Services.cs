using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models
{
    [Table("Service")]
    public class Services
    {
        [Key]
        public int ServiceID { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public string? Icon { get; set; }

    }
}
