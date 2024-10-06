using E_Commerce.Interfaces;
using E_Commerce.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepo _categoryRepo;
        public CategoryController(ICategoryRepo categoryRepo) => _categoryRepo = categoryRepo;


        public IActionResult Index()
        {
            return View();
        }

        #region data views
        public IActionResult GetAll()
        {
            ICollection<Category> categories = _categoryRepo.GetAll();
            return View(categories);
        }
        public IActionResult Details(int id)
        {
            Category? category = _categoryRepo.GetById(id);
            return View("GetById", category);
        }
        #endregion

        #region form views
        public IActionResult AddForm()
        {
            return View();
        }
        public IActionResult EditForm(int id)
        {
            Category? category = _categoryRepo.GetById(id);
            return View(category);
        }
        #endregion

        #region functions
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.Insert(category);
                return RedirectToAction("GetAll");
            }
            return View("AddForm");
        }
        public IActionResult Edit(Category category)
        {
            _categoryRepo.Update(category);
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(int id)
        {
            Category? category = _categoryRepo.GetById(id);
            _categoryRepo.Delete(category);
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}
