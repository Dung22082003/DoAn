using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn.Models
{
    [Table("about_us")]
    public class AboutUs
    {
        [Key]
        public long id { get; set; }
        public string name { get; set; }
        public string header { get; set; }
        public string subheader { get; set; }
        public string image { get; set; }
    }
}
