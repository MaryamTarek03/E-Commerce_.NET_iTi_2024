using E_Commerce.Interfaces;
using E_Commerce.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_.NET_iTi_2024.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepo _orderRepo;
        public OrderController(IOrderRepo orderRepo) => _orderRepo = orderRepo;
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
        public IActionResult GetById(int id)
        {
            Order? order = _orderRepo.GetById(id);
            return View(order);
        }
        #endregion

        #region form views
        public IActionResult AddForm(Order order)
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
            return View("GetAll");
        }
        public IActionResult Delete(int id)
        {
            Order? order = _orderRepo.GetById(id);
            _orderRepo.Delete(order);
            return View("GetAll");
        }
        #endregion
    }
}

