using PersonAPI.Domain.Entities;

namespace PersonAPI.Application.Interfaces.Repositories;

public interface IPersonRepository
{
    Task<Person> AddAsync(Person person);
    Task<Person?> UpdateAsync(Person person);
    Task<Person?> DeleteAsync(Person person);
    IQueryable<Person> GetAll();
}