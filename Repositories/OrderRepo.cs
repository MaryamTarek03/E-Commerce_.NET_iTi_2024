using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

namespace E_Commerce.Repositories
{
    public class OrderRepo : IOrderRepo
    {
        ShopContext _context;
        public OrderRepo() => _context = new ShopContext();

        public ICollection<Order> GetAll()
        {
            throw new NotImplementedException();
        }
        public Order? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Order order)
        {
            throw new NotImplementedException();
        }
        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
        public void Delete(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
