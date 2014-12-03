
namespace Warp.Core.Query
{
    /// <summary>
    /// Used to Execute IQuery<T> objects.
    /// </summary>
    public interface IQueryDispatcher
    {
        TResult Execute<TResult>(IQuery<TResult> query);
    }
}