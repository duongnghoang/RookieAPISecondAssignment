using PersonAPI.Application.Interfaces.Persons;
using PersonAPI.Application.Interfaces.Repositories;
using PersonAPI.Domain.Entities;
using PersonAPI.Domain.Shared;

namespace PersonAPI.Application.UseCases.Persons.AddPersonUseCases;

public class AddPersonUseCase : IAddPersonUseCase
{
    private readonly IPersonRepository _personRepository;

    public AddPersonUseCase(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<Result<AddPersonResponse>> ExecuteAsync(AddPersonRequest request)
    {
        var person = new Person(request.FirstName, request.LastName, request.DateOfBirth, request.Gender, request.BirthPlace);
        var result = await _personRepository.AddAsync(person);
        return Result.Success(new AddPersonResponse());
    }
}