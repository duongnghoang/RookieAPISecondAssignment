using PersonAPI.Application.Services.Persons.AddPersonServices;

namespace PersonAPI.Application.Interfaces.Persons;

public interface IAddPersonService : IBaseUseCase<AddPersonRequest, AddPersonResponse>
{
}