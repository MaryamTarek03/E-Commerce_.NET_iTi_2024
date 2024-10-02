using E_Commerce.Models.DbModels;

namespace E_Commerce.Interfaces
{
    public interface IOrderRepo
    {
        public Order? GetById(int id);
        public ICollection<Order> GetAll();
        public void Insert(Order order);
        public void Update(Order order);
        public void Delete(Order order);
        public bool OrderExist(int id);
    }
}
