using PersonAPI.Domain.Enums;

namespace PersonAPI.Domain.Entities;

public class Person : Entity
{
    public Person(Guid id, string? firstName, string? lastName, DateTime dateOfBirth, Gender gender, string? birthPlace) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Gender = gender;
        BirthPlace = birthPlace;
    }

    public Person(string? firstName, string? lastName, DateTime dateOfBirth, Gender gender, string? birthPlace)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Gender = gender;
        BirthPlace = birthPlace;
    }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string? BirthPlace { get; set; }
}