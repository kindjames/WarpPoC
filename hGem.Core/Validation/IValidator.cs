using System.Collections.Generic;

namespace hGem.Core.Validation
{
    public interface IValidator<T>
    {
        ValidationResponse Validate(T obj);
        ValidationResponse Validate(T obj, bool suppressWarnings);
    }

    public sealed class ValidationMessage
    {
        
    }

    public sealed class ValidationResponse
    {
        public IEnumerable<string> Messages { get; set; }
    }

}
