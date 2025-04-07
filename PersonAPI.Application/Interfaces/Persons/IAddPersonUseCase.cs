using PersonAPI.Application.UseCases.Persons.AddPersonUseCases;

namespace PersonAPI.Application.Interfaces.Persons;

public interface IAddPersonUseCase : IBaseUseCase<AddPersonRequest, AddPersonResponse>
{
}