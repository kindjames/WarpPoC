using System.Collections.Generic;

namespace TestFactory.Util
{
    public interface ITestDataFactory<T>
    {
        IEnumerable<T> BuildMemorySet();
    }
}