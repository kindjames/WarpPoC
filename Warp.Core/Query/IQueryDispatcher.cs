
using System;

namespace Warp.Core.Query
{
    /// <summary>
    /// Responsible for handling all Query objects.
    /// </summary>
    public interface IQueryDispatcher
    {
        TResult Execute<TResult, TQuery>(Func<TQuery, TQuery> query)
            where TQuery : class, IQuery<TResult>, new();

        TResult Execute<TResult>(IQuery<TResult> query);
    }
}