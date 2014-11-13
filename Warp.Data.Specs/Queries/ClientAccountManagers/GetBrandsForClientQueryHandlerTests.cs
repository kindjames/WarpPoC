using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.ClientAccountManagers;
using Warp.Data.Queries.Clients;

namespace Warp.Data.Specs.Queries.ClientAccountManagers
{
    [Subject("Check Client Account Managers Exists Code Query")]
    public class CheckClientAccountManagerExistsQueryHandlerTests
    {
        public class When_querying_for_a__ClientAccountManager__that_exists : WithSubject<CheckClientAccountManagerExistsQueryHandler>
        {
            const int AccountManagerId = 123;
            static bool _result;

            Establish that = () =>
                // Mock the Clients DbSet.
                The<IHospitalityGemDbContext>()
                    .WhenToldTo(d => d.ClientAccountManagers)
                    .Return(new InMemoryDbSet<ClientAccountManager>(true)
                    {
                        new ClientAccountManager {AccountManagerID = 111},
                        new ClientAccountManager {AccountManagerID = AccountManagerId},
                        new ClientAccountManager {AccountManagerID = 312},
                    });

            Because of = () => _result = Subject.Execute(new CheckClientAccountManagerExistsQuery { AccountManagerId = AccountManagerId});

            It should_return_true = () =>
                _result.ShouldBeTrue();
        }

        public class When_querying_for_a__ClientAccountManager__that__does_not_exist : WithSubject<CheckClientAccountManagerExistsQueryHandler>
        {
            const int AccountManagerId = 123;
            static bool _result;

            Establish that = () =>
                // Mock the Clients DbSet.
                The<IHospitalityGemDbContext>()
                    .WhenToldTo(d => d.ClientAccountManagers)
                    .Return(new InMemoryDbSet<ClientAccountManager>(true)
                    {
                        new ClientAccountManager {AccountManagerID = 111},
                        new ClientAccountManager {AccountManagerID = 222},
                        new ClientAccountManager {AccountManagerID = 312},
                    });

            Because of = () => _result = Subject.Execute(new CheckClientAccountManagerExistsQuery { AccountManagerId = AccountManagerId });

            It should_return_true = () =>
                _result.ShouldBeFalse();
        }
    }
}