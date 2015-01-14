using System.Collections.Generic;

namespace Warp.Core.Domain
{
    public interface IOperationResult
    {
        bool Succeeded { get; }
        IEnumerable<int> ErrorCodes { get; }
    }
}