using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.General;

namespace Warp.Services
{
    public interface IQueryContext<out TResult>
    {
        IResponse<TResult> FromQuery<TEntity>(IQuery<TEntity> query);
    }
}