using PersonAPI.Application.Interfaces.Persons;
using PersonAPI.Application.Interfaces.Repositories;
using PersonAPI.Domain.Entities;
using PersonAPI.Domain.Shared;

namespace PersonAPI.Application.Services.Persons.UpdatePersonServices;

public class UpdatePersonService : IUpdatePersonService
{
    private readonly IPersonRepository _personRepository;
    public UpdatePersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    public async Task<Result<UpdatePersonResponse>> ExecuteAsync(UpdatePersonRequest request)
    {
        var person = new Person(request.Id, request.FirstName, request.LastName, request.DateOfBirth, request.Gender, request.BirthPlace);
        var updatedPerson = await _personRepository.UpdateAsync(person);
        if (updatedPerson == null)
        {
            return Result.Failure<UpdatePersonResponse>("Person not found");
        }

        var result = new UpdatePersonResponse
        {
            Id = updatedPerson.Id,
            FirstName = updatedPerson.FirstName,
            LastName = updatedPerson.LastName,
            DateOfBirth = updatedPerson.DateOfBirth,
            Gender = updatedPerson.Gender,
            BirthPlace = updatedPerson.BirthPlace
        };

        return Result.Success(result);
    }
}