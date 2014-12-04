using System.Collections.Generic;
using TestFactory.Util;
using Warp.Data.Entities;

namespace TestFactory.Data
{
    public class BrandsTestDataFactory : ITestDataFactory<Brand>
    {
        public IEnumerable<Brand> BuildMemorySet()
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