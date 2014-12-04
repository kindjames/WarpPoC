using System.Collections.Generic;
using System.Linq;
using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Brands;

namespace Warp.Data.Specs.Queries.Brands
{
    [Subject("Get Brands For Client Query Handler")]
    public class GetBrandsForClientQueryHandlerTests
    {
        public class When_querying_for_brands_by_client_id_and_one_exists_in_the_datastore : WithSubject<GetBrandsForClientQueryHandler>
        {
            const int ClientId = 100;
            static IEnumerable<Brand> _result;

            Establish that = () =>
                // Add some dummy Brands to the in-memory DbContext.
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Brands)
                    .Return(new InMemoryDbSet<Brand>(true)
                    {
                        new Brand {Client = new Client {ClientId = ClientId}},
                        new Brand {Client = new Client {ClientId = 123}},
                        new Brand {Client = new Client {ClientId = 312}},
                    });

            Because of = () => _result = Subject.Execute(new GetBrandsForClientQuery { ClientId = ClientId });

            It should = () =>
            {
                _result.Count().ShouldEqual(1);
                _result.Single().Client.ClientId.ShouldEqual(ClientId);
            };
        }

        public class When_querying_for_brands_by_client_id_and_multiple_exist_in_the_datastore : WithSubject<GetBrandsForClientQueryHandler>
        {
            const int ClientId = 100;
            static IEnumerable<Brand> _result;
                
            Establish that = () =>
                // Add some dummy Brands to the in-memory DbContext.
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Brands)
                    .Return(new InMemoryDbSet<Brand>(true)
                    {
                        new Brand {Client = new Client {ClientId = 65}},
                        new Brand {Client = new Client {ClientId = 34}},
                        new Brand {Client = new Client {ClientId = ClientId}},
                        new Brand {Client = new Client {ClientId = ClientId}},
                        new Brand {Client = new Client {ClientId = 123}},
                        new Brand {Client = new Client {ClientId = 312}},
                        new Brand {Client = new Client {ClientId = ClientId}},
                        new Brand {Client = new Client {ClientId = ClientId}},
                    });

            Because of = () => _result = Subject.Execute(new GetBrandsForClientQuery { ClientId = ClientId });

            It should = () =>
            {
                _result.Count().ShouldEqual(4);
                _result.All(b => b.Client.ClientId == ClientId).ShouldBeTrue();
            };
        }
    }
}