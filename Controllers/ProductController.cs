using E_Commerce.Interfaces;
using E_Commerce.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_.NET_iTi_2024.Controllers
{
    public class ProductController : Controller
    {
        IProductRepo _productRepo;
        public ProductController(IProductRepo productRepo) => _productRepo = productRepo;

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
        public IActionResult GetById(int id)
        {
            Product? product = _productRepo.GetById(id);
            return View(product);
        }
        #endregion

        #region form views
        public IActionResult AddForm(Product product)
        {
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
            return View("GetAll");
        }
        public IActionResult Delete(int id)
        {
            Product? Product = _productRepo.GetById(id);
            _productRepo.Delete(Product);
            return View("GetAll");
        }
        #endregion
    }
}
