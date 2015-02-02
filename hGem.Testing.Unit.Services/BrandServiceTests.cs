using System;
using System.Collections.Generic;
using hGem.Core.Cqrs;
using hGem.Core.Exceptions.Data;
using hGem.Data.Entities;
using hGem.Data.Queries.Brands;
using hGem.Services;
using Machine.Fakes;
using Machine.Specifications;
using MoqIt = Moq.It;
using ThenIt = Machine.Specifications.It;

namespace hGem.Testing.Unit.Services
{
    [Subject("Brand Service")]
    public class BrandServiceTests
    {
        public class When_getting_brand_summary_list_for_client_that_does_not_exist : WithSubject<BrandService>
        {
            static readonly Guid NonExistingClientId = Guid.NewGuid();
            private static Exception _exception;

            Establish that = () =>
                The<IDispatcher>()
                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<GetBrandsForClientQuery>()))
                    .Return((IEnumerable<Brand>)null);

            Because of = () => _exception = Catch.Exception(() => Subject.GetBrandSummaryListForClient(NonExistingClientId));

            ThenIt should_error = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<DataEntityNotFoundException<Client>>();
                _exception.ShouldContainErrorMessage(NonExistingClientId.ToString());
            };
        }
    }
}