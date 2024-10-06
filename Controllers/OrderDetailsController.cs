using E_Commerce.Interfaces;
using E_Commerce.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class OrderDetailsController : Controller
    {
        IOrderDetailRepo _orderDetailRepo;
        IProductRepo _productRepo;
        public OrderDetailsController(IOrderDetailRepo orderDetailRepo, IProductRepo productRepo)
        {
            _orderDetailRepo = orderDetailRepo;
            _productRepo = productRepo;
        }

        public IActionResult Details(int id)
        {
            OrderDetail? orderDetail = _orderDetailRepo.GetById(id);
            return View(orderDetail);
        }
        public IActionResult GetAll()
        {
            ICollection<OrderDetail> orderDetails = _orderDetailRepo.GetAll();
            return View(orderDetails);
        }
        public IActionResult AddForm(int id)
        {
            OrderDetail orderDetail = new()
            {
                OrderId = id
            };
            ViewBag.Products = _productRepo.GetAll();
            return View(orderDetail);
        }
        public IActionResult EditForm(int id)
        {
            OrderDetail? orderDetail = _orderDetailRepo.GetById(id);
            ViewBag.Products = _productRepo.GetAll();
            return View(orderDetail);
        }
        public IActionResult Add(OrderDetail orderDetail)
        {
            _orderDetailRepo.Insert(orderDetail);
            return RedirectToAction("Details", "Order", new { id = orderDetail.OrderId });
        }
        public IActionResult Edit(OrderDetail orderDetail)
        {
            _orderDetailRepo.Update(orderDetail);
            return RedirectToAction("Details", "Order", new {id = orderDetail.OrderId});
        }
        public IActionResult Delete(int id)
        {
            OrderDetail? orderDetail = _orderDetailRepo.GetById(id);
            _orderDetailRepo.Delete(orderDetail);
            return RedirectToAction("Details", "Order", new { id = orderDetail.OrderId });
        }

        public IActionResult ValidQuantity(int quantity)
        {
            if (quantity > 0 && quantity < 100) return Json(true);
            return Json(false);
        }
    }
}