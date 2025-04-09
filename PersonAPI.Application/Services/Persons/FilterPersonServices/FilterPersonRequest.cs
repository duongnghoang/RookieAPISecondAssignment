using PersonAPI.Domain.Enums;

namespace PersonAPI.Application.Services.Persons.FilterPersonServices;

public class FilterPersonRequest
{
    public string? Name { get; set; }
    public Gender? Gender { get; set; }
    public string? BirthPlace { get; set; }
}