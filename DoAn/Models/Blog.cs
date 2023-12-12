using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models

{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string? Alias { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Img { get; set; }
        public bool? IsActive { get; set; }
       

    }
}
