using System.Collections.Generic;

namespace Warp.Testing.Unit.Data.Util
{
    public interface ITestDataFactory<out T>
    {
        IEnumerable<T> Build();
    }
}