using System.ComponentModel.DataAnnotations;

namespace KoiCareSystemAtHome.WebApplication.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
    }
}
