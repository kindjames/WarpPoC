using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.General;

namespace Warp.Testing.Integration.Data.Queries.General
{
    [Subject("Check Entity Exists Query")]
    public class CheckEntityExistsQueryHandlerTests
    {
        public class When_querying_for_a_client_that_exists : WithSubject<CheckEntityExistsQueryHandler<Client>>
        {
            const int AnIdThatIsSureToExistInTheDatabase = 1;
            static bool _result;
            
            Establish that = () =>
            {
                Configure(r => r.For<IDateTimeProvider>().Use<DateTimeProvider>());
                Configure(r => r.For<IApplicationConfig>().Use<ApplicationConfig>());
                Configure(r => r.For<IDomainDbContext>().Use<DomainDbContext>());
            };

            Because of = () => _result = Subject.Execute(new CheckEntityExistsQuery<Client> { EntityId = 1 });

            It should_return_true = () =>
                _result.ShouldBeTrue();
        }
    }
}