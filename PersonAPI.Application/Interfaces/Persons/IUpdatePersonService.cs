using PersonAPI.Application.Services.Persons.UpdatePersonServices;

namespace PersonAPI.Application.Interfaces.Persons;

public interface IUpdatePersonService : IBaseUseCase<UpdatePersonRequest, UpdatePersonResponse>
{
}