using E_Commerce.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base() { }
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseNpgsql("Host=localhost;Username=postgres;Password=root;Database=iTiECommerce");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductCategory>()
            //    .HasKey(pc => new { pc.ProductId, pc.CategoryId });

            //modelBuilder.Entity<OrderDetail>()
            //    .HasKey(od => new { od.OrderId, od.ProductId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
