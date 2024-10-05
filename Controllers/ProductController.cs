using E_Commerce.Interfaces;
using E_Commerce.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_.NET_iTi_2024.Controllers
{
    public class ProductController : Controller
    {
        IProductRepo _productRepo;
        ICategoryRepo _categoryRepo;
        public ProductController(IProductRepo productRepo, ICategoryRepo categoryRepo)
        {
            _productRepo = productRepo;
            _categoryRepo = categoryRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region data views
        public IActionResult GetAll()
        {
            ICollection<Product> products = _productRepo.GetAll().ToList();
            return View(products);
        }
        public IActionResult Details(int id)
        {
            Product? product = _productRepo.GetById(id);
            return View("GetById", product);
        }
        #endregion

        #region form views
        public IActionResult AddForm()
        {
            ViewBag.Categories = _categoryRepo.GetAll();
            return View();
        }
        public IActionResult EditForm(int id)
        {
            Product? Product = _productRepo.GetById(id);
            return View(Product);
        }
        #endregion

        #region functions
        public IActionResult Add(Product product)
        {
            _productRepo.Insert(product);
            return RedirectToAction("GetAll");
        }
        public IActionResult Edit(Product product)
        {
            _productRepo.Update(product);
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(int id)
        {
            Product? Product = _productRepo.GetById(id);
            _productRepo.Delete(Product);
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}
