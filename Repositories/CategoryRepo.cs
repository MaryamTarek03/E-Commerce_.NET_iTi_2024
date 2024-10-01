using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

namespace E_Commerce.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        ShopContext _context;
        public CategoryRepo() => _context = new ShopContext();

        public ICollection<Category> GetAll()
        {
            throw new NotImplementedException();
        }
        public Category? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category category)
        {
            throw new NotImplementedException();
        }
        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
