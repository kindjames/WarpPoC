namespace Warp.Core.Query
{
    /// <summary>
    /// A Query is a POCO that contains all properties that a QueryHandler will need, to perform its data-store query.
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IQuery<TResult>
    {
    }
}