using PersonAPI.Domain.Entities;
using System.Linq.Expressions;

namespace PersonAPI.Application.Interfaces.Repositories;

public interface IPersonRepository
{
    Task<Person> AddAsync(Person person);
    Task<Person?> DeleteAsync(Guid id);
    IQueryable<Person> GetAll();
    Task<Person?> UpdateAsync(Person person);
}