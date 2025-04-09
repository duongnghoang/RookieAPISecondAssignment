using Microsoft.EntityFrameworkCore;
using PersonAPI.Application.Interfaces.Repositories;
using PersonAPI.Application.Services.Persons.FilterPersonServices;
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
        if (existingPerson != null)
        {
            // Mapping properties from the incoming person to the existing person
            existingPerson.FirstName = person.FirstName;
            existingPerson.LastName = person.LastName;
            existingPerson.DateOfBirth = person.DateOfBirth;
            existingPerson.Gender = person.Gender;
            existingPerson.BirthPlace = person.BirthPlace;
            await _context.SaveChangesAsync();
        }

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

    public async Task<List<FilterPersonResponse>> GetAll(FilterPersonRequest request)
    {
        // Return a IQueryable list for query data
        var persons = _context.Persons.AsQueryable();
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

        return result;
    }
}