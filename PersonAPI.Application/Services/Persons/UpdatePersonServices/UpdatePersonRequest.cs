using FluentValidation;
using PersonAPI.Application.Validators;
using PersonAPI.Domain.Enums;

namespace PersonAPI.Application.Services.Persons.UpdatePersonServices;

public class UpdatePersonRequest
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string? BirthPlace { get; set; }
}

public class UpdatePersonRequestValidator : AbstractValidator<UpdatePersonRequest>
{
    private readonly DateTime _startDate = new DateTime(1900, 1, 1);
    private readonly DateTime _endDate = DateTime.Now;
    public UpdatePersonRequestValidator()
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