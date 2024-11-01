using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoiCareSystemAtHome.WebApplication.Models
{
	public class Post
	{
		[Key]
		public int PostID { get; set; }

		[Required]
		[StringLength(255)]
		public string Title { get; set; }

		[Required]
		public string Content { get; set; }

		[ForeignKey("Category")]
		public int CategoryID { get; set; }

		public Category Category { get; set; }

		public DateTime CreatedAt { get; set; } = DateTime.Now;

		public DateTime? UpdatedAt { get; set; }
	}
}
