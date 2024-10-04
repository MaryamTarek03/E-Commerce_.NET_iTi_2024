using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

namespace E_Commerce.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        readonly ShopContext _context;
        public CategoryRepo() => _context = new ShopContext();

        public ICollection<Category> GetAll() => _context.Categories.ToList();
        public Category? GetById(int id) => _context.Categories.SingleOrDefault(c => c.Id == id);

        public void Insert(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        public void Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
        
        public bool CategoryExist(string name) => _context.Categories.Any(c => c.Name == name);
    }
}