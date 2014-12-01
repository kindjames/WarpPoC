using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Queries.Clients;
using Client = Warp.Data.Entities.Client;

namespace Warp.Data.Specs.Queries.Clients
{
    [Subject("Check Client Exists For Code Query")]
    public class CheckClientExistsForCodeQueryHandlerTests
    {
        public class When_querying_for_a_client_that_exists : WithSubject<CheckClientExistsForCodeQueryHandler>
        {
            const int CustomerId = 123;
            const string Code = "asd";
            static bool _result;

            Establish that = () =>
                // Mock the Clients DbSet.
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Clients)
                    .Return(new InMemoryDbSet<Client>(true)
                    {
                        new Client {CustomerId = 111, Code = "qwe"},
                        new Client {CustomerId = CustomerId, Code = "asd"},
                        new Client {CustomerId = 312, Code = "zxc"},
                    });

            Because of = () => _result = Subject.Execute(new CheckClientExistsForCodeQuery { CustomerId = CustomerId, ClientCode = Code });

            It should_return_true = () =>
                _result.ShouldBeTrue();
        }

        public class When_querying_for_a_client_that_does_not_exist : WithSubject<CheckClientExistsForCodeQueryHandler>
        {
            const int CustomerId = 123;
            const string Code = "asd";
            static bool _result;

            Establish that = () =>
                // Mock the Clients DbSet.
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Clients)
                    .Return(new InMemoryDbSet<Client>(true)
                    {
                        new Client {CustomerId = 111, Code = "qwe"},
                        new Client {CustomerId = 222, Code = "asd"},
                        new Client {CustomerId = 312, Code = "zxc"},
                    });

            Because of = () => _result = Subject.Execute(new CheckClientExistsForCodeQuery { CustomerId = CustomerId, ClientCode = Code });

            It should_return_true = () =>
                _result.ShouldBeFalse();
        }
    }
}