namespace E_Commerce.Models.DbModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty; // change to default image
        public string Image { get; set; } = string.Empty; // this too
        //public string Category { get; set; } = string.Empty; // do we even need this?
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int Stock { get; set; }

        public virtual ICollection<ProductCategory>? ProductCategories { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }

}
