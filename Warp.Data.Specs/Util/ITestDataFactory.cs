using System.Collections.Generic;

namespace Warp.Data.Specs.TestDataFactories
{
    public interface ITestDataFactory<T>
    {
        IEnumerable<T> Build();
    }
}