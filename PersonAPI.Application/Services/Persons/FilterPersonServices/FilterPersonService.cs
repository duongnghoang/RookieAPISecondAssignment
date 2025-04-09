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
        var persons = _personRepository.GetAll();
        if (!string.IsNullOrEmpty(request.Name))
        {
            persons = persons.Where(p => p.LastName!.Contains(request.Name) ||
                p.FirstName!.Contains(request.Name));
        }
        if (request.Gender.HasValue)
        {
            persons = persons.Where(p => p.Gender == request.Gender);
        }
        if (request.BirthPlace != null)
        {
            persons = persons.Where(p => p.BirthPlace!.Contains(request.BirthPlace));
        }
        var result = await persons.Select(p => new FilterPersonResponse
        {
            Id = p.Id,
            FirstName = p.FirstName,
            LastName = p.LastName,
            Gender = p.Gender,
            BirthPlace = p.BirthPlace,
            DateOfBirth = p.DateOfBirth,
        }).ToListAsync();

        return Result.Success(result);
    }
}