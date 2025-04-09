using FluentValidation;
using PersonAPI.Domain.Enums;
using PersonAPI.Domain.Validations;
using System.ComponentModel.DataAnnotations;
using PersonAPI.Application.Validators;

namespace PersonAPI.Application.Services.Persons.AddPersonServices;

public class AddPersonRequest
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string? BirthPlace { get; set; }
}

public class AddPersonRequestValidator : AbstractValidator<AddPersonRequest>
{
    private readonly DateTime _startDate = new DateTime(1900, 1, 1);
    private readonly DateTime _endDate = DateTime.Now;
    public AddPersonRequestValidator()
    {
        RuleFor(request => request.FirstName)
            .NotEmpty().WithMessage(ValidationErrorMessage.NullOrEmpty("FirstName"));

        RuleFor(request => request.LastName)
            .NotEmpty().WithMessage(ValidationErrorMessage.NullOrEmpty("LastName"));

        RuleFor(request => request.DateOfBirth)
            .NotEmpty().WithMessage(ValidationErrorMessage.NullOrEmpty("DateOfBirth"))
            .Must(date => date != default(DateTime)).WithMessage(ValidationErrorMessage.InvalidDate("DateOfBirth"))
            .InclusiveBetween(_startDate, _endDate).WithMessage(ValidationErrorMessage.InvalidDateRange("DateOfBirth", _startDate, _endDate));

        RuleFor(request => request.Gender)
            .IsInEnum().WithMessage(ValidationErrorMessage.InvalidEnum<Gender>());
    }
}

