using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

namespace E_Commerce.Repositories
{
    public class OrderDetailRepo : IOrderDetailRepo
    {
        readonly ShopContext _context;
        public OrderDetailRepo() => _context = new ShopContext();

        public ICollection<OrderDetail> GetAll() => _context.OrderDetails.ToList();
        public OrderDetail? GetById(int orderId, int productId)
            => _context.OrderDetails.SingleOrDefault(od => od.OrderId == orderId && od.ProductId == productId);

        public void Insert(OrderDetail orderDetail) => _context.OrderDetails.Add(orderDetail);
        public void Update(OrderDetail orderDetail) => _context.OrderDetails.Update(orderDetail);
        public void Delete(OrderDetail orderDetail) => _context.OrderDetails.Remove(orderDetail);
    }
}