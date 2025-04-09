using PersonAPI.Application.Services.Persons.FilterPersonServices;

namespace PersonAPI.Application.Interfaces.Persons;

public interface IFilterPersonService : IBaseUseCase<FilterPersonRequest, List<FilterPersonResponse>>
{
}