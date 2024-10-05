using E_Commerce.Interfaces;
using E_Commerce.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerRepo _customerRepo;
        public CustomerController(ICustomerRepo customerRepo) => _customerRepo = customerRepo;

        public IActionResult Index()
        {
            return View();
        }

        // data views
        public IActionResult GetAll()
        {
            ICollection<Customer> customers = _customerRepo.GetAll();
            return View(customers);
        }
        public IActionResult Details(int id)
        {
            Customer? customer = _customerRepo.GetById(id);
            return View("GetById", customer);
        }

        // form views
        public IActionResult AddForm() // sign up maybe? you know what scrap the authentication part
        {
            return View();
        }
        public IActionResult EditForm(int id)
        {
            Customer? customer = _customerRepo.GetById(id);
            return View(customer);
        }

        // functions
        public IActionResult Add(Customer customer)
        {
            _customerRepo.Insert(customer);
            return RedirectToAction("GetAll");
        }
        public IActionResult Edit(Customer customer)
        {
            _customerRepo.Update(customer);
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(int id)
        {
            Customer? customer = _customerRepo.GetById(id);
            _customerRepo.Delete(customer);
            return RedirectToAction("GetAll");
        }
    }
}
