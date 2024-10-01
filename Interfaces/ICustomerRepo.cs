using E_Commerce.Models.DbModels;

namespace E_Commerce.Interfaces
{
    public interface ICustomerRepo
    {
        public Customer GetById(int id);
        public ICollection<Customer> GetAll();
        public void Insert(Customer customer);
        public void Update(Customer customer);
        public void Delete(Customer customer);
        public bool UsernameExist(string username); // will help in validating new username
    }
}
