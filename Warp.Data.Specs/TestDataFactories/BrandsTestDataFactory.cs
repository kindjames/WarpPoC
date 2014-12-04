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
                new Brand {Client = new Client {ClientId = 123}},
                new Brand {Client = new Client {ClientId = 1234433}},
                new Brand {Client = new Client {ClientId = 143}},
                new Brand {Client = new Client {ClientId = 103}},
                new Brand {Client = new Client {ClientId = 100}},
                new Brand {Client = new Client {ClientId = 126}},
                new Brand {Client = new Client {ClientId = 12}},
            };
        }
    }
} 