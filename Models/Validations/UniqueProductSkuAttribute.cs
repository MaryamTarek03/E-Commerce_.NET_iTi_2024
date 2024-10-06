using E_Commerce.Interfaces;
using E_Commerce.Repositories;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models.Validations
{
    public class UniqueProductSkuAttribute : ValidationAttribute
    {
        IProductRepo _productRepo;
        //public UniqueProductSkuAttribute(ProductRepo productRepo) => _productRepo = productRepo;
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null) return null;
            _productRepo = (IProductRepo)validationContext.GetService(typeof(IProductRepo));
            if (!_productRepo.SkuExist(value.ToString())) return ValidationResult.Success;
            return new ValidationResult("This SKU already exists!");
        }
    }
}
