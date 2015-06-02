using System;
using System.ComponentModel.DataAnnotations;

namespace Sitecore.EntityServiceBoilerplate.Attributes
{
    public class RandomResultAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var randomInt = new Random().Next(0, 1);

            var condition = randomInt == 1;
        
            if (condition)
                return ValidationResult.Success;

            return new ValidationResult(ErrorMessage);
        }

    }
}