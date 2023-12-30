using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security;

namespace DoAn.Models
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        public int ContactID {  get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }

    }
}
