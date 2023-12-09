using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models
{
    [Table("FoodMenu")]
    public class FoodMenu
    {
        [Key]
        public long FoodID { get; set; }
        public int TypeFoodID { get; set; }
        public string? Title { get; set; }
        public string? Contents { get; set; }
        public string? Image{ get; set; }
        public string? Cost { get; set; }
    }
}
