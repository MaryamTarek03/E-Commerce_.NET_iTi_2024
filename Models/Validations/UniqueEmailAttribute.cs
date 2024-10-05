using E_Commerce.Repositories;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models.Validations
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        CustomerRepo _customerRepo;
        public UniqueEmailAttribute(CustomerRepo customerRepo) => _customerRepo = customerRepo;
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null) return null;
            if (!_customerRepo.EmailExist(value.ToString())) return ValidationResult.Success;
            return new ValidationResult("This E-Mail already exists!");
        }
    }
}
