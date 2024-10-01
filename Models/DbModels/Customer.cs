namespace E_Commerce.Models.DbModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string BillingAddress { get; set; } = string.Empty;
        public string DefaultShippingAddress { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public virtual ICollection<Order>? Orders { get; set; }
    }
}
