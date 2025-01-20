using E_commerce.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [Required]
        public UserRoles Role { get; set; }
    }
}
