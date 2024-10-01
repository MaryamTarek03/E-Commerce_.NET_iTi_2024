using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

namespace E_Commerce.Repositories
{
    public class ProductCategoryRepo : IProductCategoryRepo
    {
        ShopContext _context;
        public ProductCategoryRepo () => _context = new ShopContext ();

        public ICollection<ProductCategory> GetAll()
        {
            throw new NotImplementedException();
        }
        public ProductCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }
        public void Update(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }
        public void Delete(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }
    }
}
