using E_Commerce.Models.DbModels;

namespace E_Commerce.Interfaces
{
    public interface ICategoryRepo
    {
        public Category? GetById(int id);
        public ICollection<Category> GetAll();
        public void Insert(Category category);
        public void Update(Category category);
        public void Delete(Category category);
        public bool CategoryExist(string categoryName);
    }
}
