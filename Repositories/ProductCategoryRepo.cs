using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

//namespace E_Commerce.Repositories
//{
//    public class ProductCategoryRepo : IProductCategoryRepo
//    {
//        readonly ShopContext _context;
//        public ProductCategoryRepo() => _context = new ShopContext();


//        public ICollection<ProductCategory> GetAll() => _context.ProductCategories.ToList();
//        public ProductCategory? GetById(int productId, int categoryId)
//            => _context.ProductCategories
//            .SingleOrDefault(pc => /*pc.ProductId == productId && */pc.CategoryId == categoryId);

//        public void Insert(ProductCategory productCategory) => _context.ProductCategories.Add(productCategory);
//        public void Update(ProductCategory productCategory) => _context.ProductCategories.Update(productCategory);
//        public void Delete(ProductCategory productCategory) => _context.ProductCategories.Remove(productCategory);

//        public bool ProductCategoryExist(int productId, int categoryId)
//            => _context.ProductCategories.Any(pc => /* pc.ProductId == productId && */pc.CategoryId == categoryId);
//    }
//}