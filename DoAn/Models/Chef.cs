using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models

{
    [Table("Chef")]
    public class Chef
    {
        [Key]
        public int ChefID { get; set; }
        public string? Name { get; set; }   
        public string? Position { get; set; }
        public string? Image { get; set; }
        public string? Fb { get; set; }
        public string? Ing { get; set; }
        public string? Icon { get; set; }
        public string? Icon_Fb { get; set;}
        public string? Icon_Ig { get; set; }
    }
}
