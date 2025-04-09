using PersonAPI.Domain.Enums;

namespace PersonAPI.Application.Services.Persons.UpdatePersonServices;

public class UpdatePersonResponse
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string? BirthPlace { get; set; }
}