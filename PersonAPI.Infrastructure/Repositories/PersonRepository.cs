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
        // Add new person to database
        _context.Persons.Add(person);
        await _context.SaveChangesAsync();
        return person;
    }

    public async Task<Person?> UpdateAsync(Person person)
    {
        // Check if the person exists in the database
        var existingPerson = await _context.Persons.FindAsync(person.Id);
        if (existingPerson == null) return existingPerson;

        // Mapping properties from the incoming person to the existing person
        existingPerson.FirstName = person.FirstName;
        existingPerson.LastName = person.LastName;
        existingPerson.DateOfBirth = person.DateOfBirth;
        existingPerson.Gender = person.Gender;
        existingPerson.BirthPlace = person.BirthPlace;

        // Update the properties of the existing person
        _context.Update(existingPerson);
        await _context.SaveChangesAsync();

        return existingPerson;
    }

    public async Task<Person?> DeleteAsync(Guid id)
    {
        // Check if the person exists in the database
        var existingPerson = await _context.Persons.FindAsync(id);
        if (existingPerson == null) return existingPerson;

        // Remove the person from the database
        _context.Persons.Remove(existingPerson);
        await _context.SaveChangesAsync();

        return existingPerson;
    }

    public IQueryable<Person> GetAll()
    {
        // Return a IQueryable list for query data
        var person = _context.Persons.AsQueryable();

        return person;
    }
}