using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationMVC
{
    public class AbhayValidationMVC : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                string message = value.ToString();
                if (message.Contains("Abhay"))
                {
                    return ValidationResult.Success;
                }
                
            }

            ErrorMessage = ErrorMessage ?? validationContext.DisplayName + "Field Must Contain Abhay";
            return new ValidationResult(ErrorMessage);
        }
    }
}