
namespace Warp.Core.Query
{
    // Interface for query handlers - has two type parameters for the query and the query result
    public interface IQueryHandler<in TQuery, out TResult>
        where TQuery : IQuery<TResult>
    {
        TResult Execute(TQuery query);
    }
}