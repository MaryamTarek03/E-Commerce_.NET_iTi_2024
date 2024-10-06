using E_Commerce.Interfaces;
using E_Commerce.Models.Validations;
using E_Commerce.Repositories;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models.DbModels
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        [UniqueCategoryName]
        public string Name { get; set; } = string.Empty;
        [MaxLength(250)]
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Thumbnail { get; set; } = string.Empty; // again default image

        public virtual ICollection<ProductCategory>? ProductCategories { get; set; }
    }
}
