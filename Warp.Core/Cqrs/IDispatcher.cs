
namespace Warp.Core.Cqrs
{
    public interface IDispatcher
    {
        void Execute(ICommand command);

        TResult Execute<TResult>(IQuery<TResult> query);

        TResult Execute<TQuery, TResult>()
            where TQuery : IQuery<TResult>, new();
    }
}