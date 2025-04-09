using PersonAPI.Application.Interfaces.Persons;
using PersonAPI.Application.Interfaces.Repositories;
using PersonAPI.Domain.Shared;

namespace PersonAPI.Application.Services.Persons.DeletePersonServices;

public class DeletePersonService : IDeletePersonService
{
    private readonly IPersonRepository _personRepository;

    public DeletePersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<Result> ExecuteAsync(Guid request)
    {
        var person = await _personRepository.DeleteAsync(request);
        if (person == null)
        {
            return Result.Failure("Person not found");
        }
        return Result.Success($"Person {request} deleted successfully");
    }
}