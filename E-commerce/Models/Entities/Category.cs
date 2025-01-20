using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        // Navigation Property
        public ICollection<Product> Products { get; set; }
    }
}
