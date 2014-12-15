
namespace Warp.Core.Query
{
    /// <summary>
    /// Responsible for handling all Query objects.
    /// </summary>
    public interface IQueryDispatcher
    {
        TResult Execute<TResult>(IQuery<TResult> query);
    }
}