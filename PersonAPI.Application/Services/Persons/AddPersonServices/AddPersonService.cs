using PersonAPI.Application.Interfaces.Persons;
using PersonAPI.Application.Interfaces.Repositories;
using PersonAPI.Domain.Entities;
using PersonAPI.Domain.Shared;

namespace PersonAPI.Application.Services.Persons.AddPersonServices;

public class AddPersonService : IAddPersonService
{
    private readonly IPersonRepository _personRepository;

    public AddPersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<Result<AddPersonResponse>> ExecuteAsync(AddPersonRequest request)
    {
        //var validationResult = await _addPersonRequestValidator.ValidateAsync(request);
        //if (!validationResult.IsValid)
        //{
        //    return Result.Failure<AddPersonResponse>(string.Join(',', validationResult.Errors.Select(e => e.ErrorMessage).ToList()));
        //}
        var person = new Person(request.FirstName, request.LastName, request.DateOfBirth, request.Gender, request.BirthPlace);
        var addedPerson = await _personRepository.AddAsync(person);
        var result = new AddPersonResponse
        {
            Id = addedPerson.Id,
            FirstName = addedPerson.FirstName,
            LastName = addedPerson.LastName,
            DateOfBirth = addedPerson.DateOfBirth,
            Gender = addedPerson.Gender,
            BirthPlace = addedPerson.BirthPlace,
        };

        return Result.Success(result);
    }
}