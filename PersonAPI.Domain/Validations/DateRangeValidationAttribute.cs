using System.ComponentModel.DataAnnotations;

namespace PersonAPI.Domain.Validations;

public class DateRangeValidationAttribute : ValidationAttribute
{
    private readonly DateTime _startDate;
    private readonly DateTime _endDate;

    public DateRangeValidationAttribute(string startDate, string? endDate = null)
    {
        _startDate = DateTime.Parse(startDate);
        if (!string.IsNullOrEmpty(endDate))
        {
            _endDate = DateTime.Parse(endDate);
        }
        _endDate = DateTime.Now;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is not DateTime dateValue)
        {
            return new ValidationResult("Invalid date format.");
        }
        if (dateValue < _startDate || dateValue > _endDate)
        {
            return new ValidationResult($"Date must be between {_startDate.ToShortDateString()} and {_endDate.ToShortDateString()}.");
        }

        return ValidationResult.Success;
    }
}