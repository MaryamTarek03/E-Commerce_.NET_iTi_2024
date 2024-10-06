using E_Commerce.Interfaces;
using E_Commerce.Repositories;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models.Validations
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        ICustomerRepo _customerRepo;
        //public UniqueEmailAttribute(CustomerRepo customerRepo) => _customerRepo = customerRepo;
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null) return null;
            _customerRepo = (ICustomerRepo)validationContext.GetService(typeof(ICustomerRepo));
            if (!_customerRepo.EmailExist(value.ToString())) return ValidationResult.Success;
            return new ValidationResult("This Email already exists!");
        }
    }
}
