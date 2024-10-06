using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

namespace E_Commerce.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        // بعرف الداتا بيز هنا عشان استعملها
        readonly ShopContext _context;
        public CustomerRepo(ShopContext context) => _context = context;

        // بجيب كل حاجة جوا الداتا بيز
        // ToList => gets all elements
        public ICollection<Customer> GetAll() => _context.Customers.ToList();

        // بجيب عميل واحد حسب الايميل او ال اي دي
        // SingleOrDefault => gets one element (1) with a WHERE condition (For example if the customer id matches the given id)
        public Customer? GetById(int id) => _context.Customers.SingleOrDefault(c => c.Id == id);
        public Customer? GetByEmail(string email) => _context.Customers.SingleOrDefault(c => c.Email == email);

        // normal database functions
        // Add يضيف عميل للداتا بيز
        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        // Update يجدد بيانات عميل
        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
        // Delete يمسح عميل
        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        //بشوف لو الايميل ده مستخدم قبل كده ولا لا (موجود ولا لا يعني) هنستعملها بعدين
        public bool EmailExist(string email) => _context.Customers.Any(c => c.Email == email);
    }
}
