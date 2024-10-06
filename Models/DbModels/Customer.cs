using E_Commerce.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models.DbModels
{
    public class Customer
    {
        public int Id { get; set; }
        [UniqueEmail]
        public string Email { get; set; } = string.Empty;
        [MinLength(8, ErrorMessage = "The password must be at least 8 characters")]
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string BillingAddress { get; set; } = string.Empty;
        public string DefaultShippingAddress { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public virtual ICollection<Order>? Orders { get; set; }
    }
}
