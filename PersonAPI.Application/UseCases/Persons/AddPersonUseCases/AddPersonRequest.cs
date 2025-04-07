using PersonAPI.Domain.Enums;

namespace PersonAPI.Application.UseCases.Persons.AddPersonUseCases;

public class AddPersonRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string BirthPlace { get; set; }
}

// Request model for updating a person
public class UpdatePersonRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string BirthPlace { get; set; }
}

// Request model for filtering people
public class FilterPersonsRequest
{
    public string? Name { get; set; } // Case-sensitive filter for FirstName or LastName
    public Gender? Gender { get; set; } // Nullable to allow optional filtering
    public string? BirthPlace { get; set; } // Case-sensitive filter for BirthPlace
}