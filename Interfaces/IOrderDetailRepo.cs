using E_Commerce.Models.DbModels;

namespace E_Commerce.Interfaces
{
    public interface IOrderDetailRepo
    {
        public OrderDetail? GetByIds(int orderId, int productId);
        public OrderDetail? GetById(int id);
        public ICollection<OrderDetail> GetAll();
        public void Insert(OrderDetail orderDetail);
        public void Update(OrderDetail orderDetail);
        public void Delete(OrderDetail orderDetail);
    }
}
