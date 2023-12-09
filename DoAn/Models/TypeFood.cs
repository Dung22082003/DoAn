using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models
{
    [Table("TypeFood")]
    public class TypeFood
    {
        [Key]
        public long TypeFoodID { get; set; }
        public string? Name { get; set; } 
    }
}
