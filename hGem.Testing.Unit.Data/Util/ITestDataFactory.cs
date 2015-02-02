using System.Collections.Generic;

namespace hGem.Testing.Unit.Data.Util
{
    public interface ITestDataFactory<out T>
    {
        IEnumerable<T> Build();
    }
}