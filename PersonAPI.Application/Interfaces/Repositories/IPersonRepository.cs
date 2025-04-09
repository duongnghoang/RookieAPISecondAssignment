using PersonAPI.Application.Services.Persons.FilterPersonServices;
using PersonAPI.Domain.Entities;
using System.Linq.Expressions;

namespace PersonAPI.Application.Interfaces.Repositories;

public interface IPersonRepository
{
    Task<Person> AddAsync(Person person);
    Task<Person?> DeleteAsync(Guid id);
    Task<List<FilterPersonResponse>> GetAll(FilterPersonRequest request);
    Task<Person?> UpdateAsync(Person person);
}