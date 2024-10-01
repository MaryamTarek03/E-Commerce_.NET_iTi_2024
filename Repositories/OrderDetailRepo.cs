using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

namespace E_Commerce.Repositories
{
    public class OrderDetailRepo : IOrderDetailRepo
    {
        ShopContext _context;
        public OrderDetailRepo() => _context = new ShopContext();

        public ICollection<OrderDetail> GetAll()
        {
            throw new NotImplementedException();
        }
        public OrderDetail? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
        public void Update(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
        public void Delete(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
