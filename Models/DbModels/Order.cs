using Castle.Core.Resource;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models.DbModels
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string ShippingAddress { get; set; } = string.Empty;
        [Required]
        public string OrderAddress { get; set; } = string.Empty;
        [Required]
        public string OrderEmail { get; set; } = string.Empty;
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string OrderStatus { get; set; } = string.Empty;

        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
