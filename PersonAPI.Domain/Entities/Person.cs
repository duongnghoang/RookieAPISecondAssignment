using PersonAPI.Domain.Enums;

namespace PersonAPI.Domain.Entities;

public class Person : Entity
{
    public Person(string firstName, string lastName, DateTime dateOfBirth, Gender gender, string birthPlace)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Gender = gender;
        BirthPlace = birthPlace;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public Gender Gender { get; private set; }
    public string BirthPlace { get; private set; }
}