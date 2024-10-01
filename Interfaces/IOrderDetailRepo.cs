using E_Commerce.Models.DbModels;

namespace E_Commerce.Interfaces
{
    public interface IOrderDetailRepo
    {
        public OrderDetail GetById(int id);
        public ICollection<OrderDetail> GetAll();
        public void Insert(OrderDetail orderDetail);
        public void Update(OrderDetail orderDetail);
        public void Delete(OrderDetail orderDetail);
    }
}
