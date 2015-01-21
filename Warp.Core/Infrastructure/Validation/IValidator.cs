using Warp.Core.Services;

namespace Warp.Core.Infrastructure.Validation
{
    public interface IValidator
    {
        IResponse Validate<T>(T obj) where T : class;
        IResponse<TResult> Validate<T, TResult>(T obj) where T : class;
        bool IsValid<T>(T obj) where T : class;
        void TryValidateAndThrow<T>(T obj) where T : class;
    }
}