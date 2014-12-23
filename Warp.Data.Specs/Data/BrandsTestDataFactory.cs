using System.Collections.Generic;
using Warp.Data.Entities;
using Warp.Data.Specs.Util;

namespace Warp.Data.Specs.Data
{
    public class BrandsTestDataFactory : ITestDataFactory<Brand>
    {
        public IEnumerable<Brand> Build()
        {
            return new[]
            {
                new Brand {Client = new Client { Id = 123}},
                new Brand {Client = new Client { Id = 1234433}},
                new Brand {Client = new Client { Id = 143}},
                new Brand {Client = new Client { Id = 103}},
                new Brand {Client = new Client { Id = 100}},
                new Brand {Client = new Client { Id = 126}},
                new Brand {Client = new Client { Id = 12}}
            };
        }
    }
}