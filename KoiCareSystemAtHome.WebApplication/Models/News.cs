using System;
using System.ComponentModel.DataAnnotations;

namespace KoiCareSystemAtHome.WebApplication.Models
{
    public class News
    {
        [Key]
        public int PostID { get; set; }

        [Required]
        [StringLength(255)]
        public string Author { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }
    }
}
