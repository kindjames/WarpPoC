using System.Collections.Generic;
using Warp.Core.Services;

namespace Warp.Core.Infrastructure.Validation
{
    public class ValidationResponse : IResponse
    {
        public bool Successful { get; private set; }

        public IReadOnlyList<string> Messages { get; private set; }
    }

    public interface IValidator
    {
        ValidationResponse Validate(object obj);
    }
}