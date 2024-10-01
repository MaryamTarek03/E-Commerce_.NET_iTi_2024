using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

namespace E_Commerce.Repositories
{
    public class ProductRepo : IProductRepo
    {
        ShopContext _context;
        public ProductRepo() => _context = new ShopContext();

        public ICollection<Product> GetAll()
        {
            // امسحي السطر ده لما تكتبي
            throw new NotImplementedException();
        }

        public Product? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }
        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

    }
}
