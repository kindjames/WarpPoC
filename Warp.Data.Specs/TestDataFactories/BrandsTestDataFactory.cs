using System.Collections.Generic;
using Warp.Data.Entities;

namespace Warp.Data.Specs.TestDataFactories
{
    public class BrandsTestDataFactory : ITestDataFactory<Brand>
    {
        public IEnumerable<Brand> Build()
        {
            return new[]
            {
                new Brand {ClientID = 123},
                new Brand {ClientID = 1234433},
                new Brand {ClientID = 143},
                new Brand {ClientID = 103},
                new Brand {ClientID = 100},
                new Brand {ClientID = 126},
                new Brand {ClientID = 12},
            };
        }
    }
}