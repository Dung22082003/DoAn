using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models
{
    [Table("About")]
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Link { get; set; }
        public int Number { get; set; }
        public string? Icon { get; set; }
    }
}
