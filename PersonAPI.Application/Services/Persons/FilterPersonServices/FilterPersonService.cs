using Microsoft.EntityFrameworkCore;
using PersonAPI.Application.Interfaces.Persons;
using PersonAPI.Application.Interfaces.Repositories;
using PersonAPI.Application.Services.Persons.UpdatePersonServices;
using PersonAPI.Domain.Shared;

namespace PersonAPI.Application.Services.Persons.FilterPersonServices;

public class FilterPersonService : IFilterPersonService
{
    private readonly IPersonRepository _personRepository;

    public FilterPersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<Result<List<FilterPersonResponse>>> ExecuteAsync(FilterPersonRequest request)
    {
        var result = await _personRepository.GetAll(request);

        return Result.Success(result);
    }
}