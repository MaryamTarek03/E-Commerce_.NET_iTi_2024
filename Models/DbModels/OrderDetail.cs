using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models.DbModels
{
    public class OrderDetail
    {
        public int Id { get; set; }

        // Foreign Keys
        public int? OrderId { get; set; }
        public virtual Order? Order { get; set; }

        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Sku { get; set; } = string.Empty;

        [Required]
        //[Remote("QuantityValid", "OrderDetails", ErrorMessage = "The quantity must be 0 at least 99 at most")]
        public int Quantity { get; set; }
    }
}
