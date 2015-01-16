using Warp.Core.Services.Dtos.Client;

namespace Warp.Core.Cqrs
{
    public interface IDispatcher
    {
        void Execute(ICommand command);
        TResult Execute<TResult>(IQuery<TResult> query);

        TResult Execute<TQuery, TResult>()
            where TQuery : IQuery<TResult>, new();

        void ExecuteUsingDto<TCommand>(DtoBase dto)
            where TCommand : ICommand, new();
        TResult ExecuteUsingDto<TQuery, TResult>(DtoBase dto)
            where TQuery : IQuery<TResult>, new();
    }
}