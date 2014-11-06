
namespace Warp.Core.Query
{
    // Interface for the query dispatcher itself
    public interface IQueryDispatcher
    {
        TResult Execute<TResult>(IQuery<TResult> query);
    }
}