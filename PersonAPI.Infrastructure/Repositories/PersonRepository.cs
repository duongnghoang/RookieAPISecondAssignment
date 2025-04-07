using PersonAPI.Application.Interfaces.Repositories;
using PersonAPI.Domain.Entities;
using PersonAPI.Persistence.Data;

namespace PersonAPI.Infrastructure.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly ApplicationDbContext _context;
    public PersonRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Person> AddAsync(Person person)
    {
        _context.Persons.Add(person);
        await _context.SaveChangesAsync();
        return person;
    }

    public async Task<Person?> UpdateAsync(Person person)
    {
        // Check if the person exists in the database
        var existingPerson = await _context.Persons.FindAsync(person.Id);
        if (existingPerson == null) return existingPerson;

        // Update the properties of the existing person
        _context.Entry(existingPerson).CurrentValues.SetValues(person);
        await _context.SaveChangesAsync();

        return existingPerson;
    }

    public async Task<Person?> DeleteAsync(Person person)
    {
        // Check if the person exists in the database
        var existingPerson = await _context.Persons.FindAsync(person.Id);
        if (existingPerson == null) return existingPerson;

        _context.Persons.Remove(existingPerson);
        await _context.SaveChangesAsync();

        return existingPerson;
    }

    public IQueryable<Person> GetAll()
    {
        return _context.Persons.AsQueryable();
    }
}