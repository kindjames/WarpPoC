using System.Collections.Generic;

namespace Warp.Core.Infrastructure.General
{
    public interface IResponse
    {
        bool Successful { get; }
        IReadOnlyList<string> Messages { get; }
    }

    public interface IResponse<out T> : IResponse
    {
        T Result { get; }
    }
}