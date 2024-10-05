using E_Commerce.Interfaces;
using E_Commerce.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_.NET_iTi_2024.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepo _orderRepo;
        ICustomerRepo _customerRepo;
        public OrderController(IOrderRepo orderRepo, ICustomerRepo customerRepo)
        {
            _orderRepo = orderRepo;
            _customerRepo = customerRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region data views
        public IActionResult GetAll()
        {
            ICollection<Order> orders = _orderRepo.GetAll();
            return View(orders);
        }
        public IActionResult Details(int id)
        {
            Order? order = _orderRepo.GetById(id);
            return View("GetById", order);
        }
        #endregion

        #region form views
        public IActionResult AddForm()
        {
            return View();
        }
        public IActionResult EditForm(int id)
        {
            Order? Order = _orderRepo.GetById(id);
            return View(Order);
        }
        #endregion

        #region  functions
        public IActionResult Add(Order order)
        {
            _orderRepo.Insert(order);
            return RedirectToAction("GetAll");
        }
        public IActionResult Edit(Order order)
        {
            _orderRepo.Update(order);
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(int id)
        {
            Order? order = _orderRepo.GetById(id);
            _orderRepo.Delete(order);
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}

