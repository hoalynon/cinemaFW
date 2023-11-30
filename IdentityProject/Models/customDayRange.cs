using System.ComponentModel.DataAnnotations;

namespace IdentityProject.Models
{
    public class customDayRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime birthDate = (DateTime)value;
            DateTime currentDate = DateTime.Now.Date;

            if (birthDate > currentDate)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
