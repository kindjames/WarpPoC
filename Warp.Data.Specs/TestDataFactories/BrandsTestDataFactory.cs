using System.Collections.Generic;
using Warp.Data.Entities;
using Warp.Data.Specs.Util;

namespace Warp.Data.Specs.TestDataFactories
{
    public class BrandsTestDataFactory : ITestDataFactory<Brand>
    {
        public IEnumerable<Brand> BuildMemorySet()
        {
            return new[]
            {
                new Brand {ClientId = 123},
                new Brand {ClientId = 1234433},
                new Brand {ClientId = 143},
                new Brand {ClientId = 103},
                new Brand {ClientId = 100},
                new Brand {ClientId = 126},
                new Brand {ClientId = 12}
            };
        }
    }
}