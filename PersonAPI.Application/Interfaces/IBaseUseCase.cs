using PersonAPI.Domain.Shared;

namespace PersonAPI.Application.Interfaces;

public interface IBaseUseCase<in TRequest, TResponse>
{
    Task<Result<TResponse>> ExecuteAsync(TRequest request);
}

public interface IBaseUseCase<in TRequest>
{
    Task<Result> ExecuteAsync(TRequest request);
}