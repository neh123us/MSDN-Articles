using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Common.Validation
{
  class Validators
  {
    public class DateRangeValidator : ValidationAttribute
    {
      public int MinimalDateOffset { get; set; }
      public int MaximumDateOffset { get; set; }
      protected override ValidationResult IsValid(object value, ValidationContext validationContext)
      {
        if (!(value is DateTime))
          return new ValidationResult("Inputted value is not a date");

        var date = (DateTime)value;
        if (date >= DateTime.Today.AddDays(MinimalDateOffset) &&
            date <= DateTime.Today.AddDays(MaximumDateOffset))
          return ValidationResult.Success;

        return new ValidationResult(ErrorMessage); 
        //return base.IsValid(value, validationContext);
      }
    }
  }
}
