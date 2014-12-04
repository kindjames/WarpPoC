using System.Collections.Generic;

namespace Warp.Data.Specs.Util
{
    public interface ITestDataFactory<out T>
    {
        IEnumerable<T> Build();
    }
}