using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models
{
    [Table("TypeEvent")]
    public class TypeEvent
    {
        [Key]
        public int TypeId { get; set; }
        public string? Name { get; set; }
        public List<Event>? Events { get; set; }
    }
}
