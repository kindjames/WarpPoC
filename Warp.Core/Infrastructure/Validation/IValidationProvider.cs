using Warp.Core.Infrastructure.General;

namespace Warp.Core.Infrastructure.Validation
{
    public interface IValidationProvider
    {
        IResponse Validate<T>(T obj) where T : class;
    }
}