using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Brands;
using Warp.Testing.Unit.Data.Commands.Clients;

namespace Warp.Testing.Unit.Data.Queries.Brands
{
    [Subject("Get Brands For Client Query Handler")]
    public class GetBrandsForClientQueryHandlerTests
    {
        public class When_querying_for_brands_by_client_id_and_one_exists_in_the_datastore : WithSubject<GetBrandsForClientQueryHandler>
        {
            static readonly Guid ClientId = Guid.NewGuid();
            static IEnumerable<Brand> _result;

            Establish that = () =>
                // Add some dummy Brands to the in-memory DbContext.
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Brands)
                    .Return(new TestDbSet<Brand>
                    {
                        new Brand {Client = new Client {Id = ClientId}},
                        new Brand {Client = new Client {Id = Guid.NewGuid()}},
                        new Brand {Client = new Client {Id = Guid.NewGuid()}}
                    });

            Because of = () => _result = Subject.Handle(new GetBrandsForClientQuery { ClientId = ClientId });

            It should = () =>
            {
                _result.Count().ShouldEqual(1);
                _result.Single().Client.Id.ShouldEqual(ClientId);
            };
        }

        public class When_querying_for_brands_by_client_id_and_multiple_exist_in_the_datastore : WithSubject<GetBrandsForClientQueryHandler>
        {
            static readonly Guid ClientId = Guid.NewGuid();
            static IEnumerable<Brand> _result;

            Establish that = () =>
                // Add some dummy Brands to the in-memory DbContext.
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Brands)
                    .Return(new TestDbSet<Brand>
                    {
                        new Brand {Client = new Client {Id = Guid.NewGuid()}},
                        new Brand {Client = new Client {Id = Guid.NewGuid()}},
                        new Brand {Client = new Client {Id = ClientId}},
                        new Brand {Client = new Client {Id = ClientId}},
                        new Brand {Client = new Client {Id = Guid.NewGuid()}},
                        new Brand {Client = new Client {Id = Guid.NewGuid()}},
                        new Brand {Client = new Client {Id = ClientId}},
                        new Brand {Client = new Client {Id = ClientId}}
                    });

            Because of = () => _result = Subject.Handle(new GetBrandsForClientQuery { ClientId = ClientId });

            It should_filter_brands = () =>
            {
                _result.Count().ShouldEqual(4);
                _result.All(b => b.Client.Id == ClientId).ShouldBeTrue();
            };
        }
    }
}