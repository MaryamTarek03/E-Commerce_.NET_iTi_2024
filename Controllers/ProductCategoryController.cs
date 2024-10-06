using E_Commerce.Interfaces;
using E_Commerce.Models.DbModels;
using E_Commerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_ASP_Net.Controllers
{
    public class ProductCategoryController : Controller
    {
        ICategoryRepo _categoryRepo;
        IProductCategoryRepo _productCategoryRepo;
        public ProductCategoryController(IProductCategoryRepo productCategoryRepo, ICategoryRepo categoryRepo)
        {
            _productCategoryRepo = productCategoryRepo;
            _categoryRepo = categoryRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
        #region data views
        //public IActionResult GetAll()
        //{
        //    ICollection<ProductCategory> productCategories = _productCategoryRepo.GetAll();
        //    ICollection<Category> categories = _categoryRepo.GetAll();
        //    ViewBag.Categories = categories;
        //    return View(productCategories);
        //}
        //public IActionResult GetById(int id)
        //{
        //    ProductCategory? productCategory = _productCategoryRepo.GetById(id);
        //    ICollection<Product> products = _productRepo.GetAll();
        //    ICollection<Category> categories = _categoryRepo.GetAll();
        //    ViewBag.product = products;
        //    ViewBag.category = categories;
        //    return View(productCategory);
        //}
        #endregion

        #region form views
        public IActionResult AddForm(int id)
        {
            ProductCategory productCategory = new()
            {
                ProductId = id
            };
            ViewBag.Categories = _categoryRepo.GetAll();
            return View(productCategory);
        }
        public IActionResult EditForm(int id)
        {
            ViewBag.Categories = _categoryRepo.GetAll();
            ProductCategory? productCategory = _productCategoryRepo.GetById(id);
            return View(productCategory);
        }
        #endregion

        #region functions
        public IActionResult Add(ProductCategory productCategory)
        {
            _productCategoryRepo.Insert(productCategory);
            return RedirectToAction("Details", "Product", new {id = productCategory.ProductId});
        }
        public IActionResult Edit(ProductCategory productCategory)
        {
            _productCategoryRepo.Update(productCategory);
            return RedirectToAction("Details", "Product", new { id = productCategory.ProductId });
        }
        public IActionResult Delete(int id)
        {
            ProductCategory? productCategory = _productCategoryRepo.GetById(id);
            _productCategoryRepo.Delete(productCategory);
            return RedirectToAction("Details", "Product", new { id = productCategory.ProductId });
        }
        #endregion
    }
}
