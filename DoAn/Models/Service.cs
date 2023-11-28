using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn.Models
{
    [Table("services")]
    public class Service
    {
        [Key]
        public int id { get; set; }
        public string content { get; set; }
        public string icon { get; set; }
        public long about_us_id { get; set; }
    }
}
