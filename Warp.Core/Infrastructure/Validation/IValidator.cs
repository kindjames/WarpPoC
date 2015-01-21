using Warp.Core.Infrastructure.General;

namespace Warp.Core.Infrastructure.Validation
{
    public interface IValidator
    {
        IResponse Validate<T>(T obj) where T : class;
    }
}