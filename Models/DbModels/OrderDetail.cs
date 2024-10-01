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

        public decimal Price { get; set; }
        public string Sku { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}
