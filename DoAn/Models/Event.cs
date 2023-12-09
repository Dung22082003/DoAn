using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models
{
    [Table("Event")]
    public class Event
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("TypeEvent")]
        public int TypeId { get; set; }
        public string? Title {  get; set; }
        public string? Images{ get; set; }
        public string? Icon { get; set; }
        
        public TypeEvent? TypeEvent { get; set; }
    }
}
