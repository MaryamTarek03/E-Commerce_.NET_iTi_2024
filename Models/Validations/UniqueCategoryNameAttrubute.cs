using E_Commerce.Repositories;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models.Validations
{
    public class UniqueCategoryNameAttribute : ValidationAttribute
    {
        CategoryRepo _categoryRepo;
        public UniqueCategoryNameAttribute(CategoryRepo categoryRepo) => _categoryRepo = categoryRepo;
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null) return null;
            if (!_categoryRepo.CategoryExist(value.ToString())) return ValidationResult.Success;
            return new ValidationResult("This category name already exists!");
        }
    }
}
