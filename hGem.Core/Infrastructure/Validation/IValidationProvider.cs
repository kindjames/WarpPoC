
namespace hGem.Core.Infrastructure.Validation
{
    public interface IValidationProvider
    {
        void ValidateAndThrow<T>(T obj) where T : class;
    }
}