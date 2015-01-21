
namespace Warp.Core.Cqrs
{
    /// <summary>
    /// Responsible for locating and executing handlers for Queries and Commands.
    /// </summary>
    public interface IDispatcher
    {
        /// <summary>
        /// Executes a Command.
        /// </summary>
        /// <param name="command"></param>
        void Execute(ICommand command);

        /// <summary>
        /// Executes a Query.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        TResult Execute<TResult>(IQuery<TResult> query);

        /// <summary>
        /// Executes a Query that has no parameters.
        /// </summary>
        /// <typeparam name="TQuery"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        TResult Execute<TQuery, TResult>()
            where TQuery : IQuery<TResult>, new();
    }
}