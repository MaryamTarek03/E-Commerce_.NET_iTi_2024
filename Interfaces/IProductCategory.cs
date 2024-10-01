using E_Commerce.Models.DbModels;

namespace E_Commerce.Interfaces
{
    public interface IProductCategory
    {
        public ProductCategory GetById(int id);
        public ICollection<ProductCategory> GetAll();
        public void Insert(ProductCategory productCategory);
        public void Update(ProductCategory productCategory);
        public void Delete(ProductCategory productCategory);
    }
}
