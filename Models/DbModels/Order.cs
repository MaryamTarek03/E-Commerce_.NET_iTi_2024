using Castle.Core.Resource;

namespace E_Commerce.Models.DbModels
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string ShippingAddress { get; set; } = string.Empty;
        public string OrderAddress { get; set; } = string.Empty;
        public string OrderEmail { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; } = string.Empty;

        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
