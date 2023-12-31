using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn.Models
{
	[Table("Footer")]
	public class Footer
	{
		[Key]
		public int FooterId { get; set; }
		public string? Intro { get; set; }
		public string? IconIntro { get; set; }
		public string? Special { get; set; }
		public string? Contact { get; set; }
		public string? IconContact { get; set; }
		public string? Gallery { get; set; }
	}
}