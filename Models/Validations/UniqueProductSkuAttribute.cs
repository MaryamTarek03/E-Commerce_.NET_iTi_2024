using E_Commerce.Repositories;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models.Validations
{
    public class UniqueProductSkuAttribute : ValidationAttribute
    {
        ProductRepo _productRepo;
        public UniqueProductSkuAttribute(ProductRepo productRepo) => _productRepo = productRepo;
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null) return null;
            if (!_productRepo.SkuExist(value.ToString())) return ValidationResult.Success;
            return new ValidationResult("This E-Mail already exists!");
        }
    }
}
