using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Clients;

namespace Warp.Data.Specs.Queries.Clients
{
    [Subject("Get Client Query Handler")]
    public class GetClientQueryHandlerTests
    {
        public class When_querying_for_client : WithSubject<GetClientQueryHandler>
        {
            const int ClientId = 100;
            static Client _result;

            Establish that = () =>
                // Mock the Clients DbSet.
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Clients)
                    .Return(new InMemoryDbSet<Client>(true)
                    {
                        new Client {Id = ClientId},
                        new Client {Id = 123},
                        new Client {Id = 312}
                    });

            Because of = () => _result = Subject.Execute(new GetClientQuery { ClientId = ClientId });

            It should_return_a_valid_client = () =>
            {
                _result.ShouldNotBeNull();
                _result.Id.ShouldEqual(ClientId);
            };
        }
    }
}