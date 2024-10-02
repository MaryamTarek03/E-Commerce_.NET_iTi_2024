using E_Commerce.Models.DbModels;

namespace E_Commerce.Interfaces
{
    public interface IProductRepo
    {
        public Product? GetById(int id);
        public ICollection<Product> GetAll();
        public void Insert(Product product);
        public void Update(Product product);
        public void Delete(Product product);
        public bool ProductExist(string productName);
    }
}
