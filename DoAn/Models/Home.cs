using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models
{
    [Table("Home")] 
    
    public class Home
    {
        [Key]
        public int HomeID { get; set; }
        public string? Title { get; set; }
        public string? Contents { get; set; }
        public string? Images {  get; set; }
    }
}
