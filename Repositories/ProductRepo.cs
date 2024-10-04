using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

namespace E_Commerce.Repositories
{
    public class ProductRepo : IProductRepo
    {
        readonly ShopContext _context;
        public ProductRepo() => _context = new ShopContext();

        public ICollection<Product> GetAll() => _context.Products.ToList();
        public Product? GetById(int id) => _context.Products.SingleOrDefault(p => p.Id == id);

        public void Insert(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public void Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public bool ProductExist(string name) => _context.Products.Any(p => p.Name == name);
    }
}