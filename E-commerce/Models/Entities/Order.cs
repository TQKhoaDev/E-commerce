using E_commerce.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        [Required]
        public string CustomerPhone { get; set; }

        [Required]
        public OrderStatus Status { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
