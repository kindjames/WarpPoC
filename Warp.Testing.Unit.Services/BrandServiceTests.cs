using System;
using System.Collections.Generic;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Exceptions.Data;
using Warp.Core.Query;
using Warp.Core.Services.Dtos.Brand;
using Warp.Data.Entities;
using Warp.Data.Queries.Brands;
using Warp.Services;
using MoqIt = Moq.It;
using ThenIt = Machine.Specifications.It;

namespace Warp.Testing.Unit.Services
{
    [Subject("Brand Service")]
    public class BrandServiceTests
    {
        public class When_getting_brand_summary_list_for_client_that_does_not_exist : WithSubject<BrandService>
        {
            static readonly Guid NonExistingClientId = Guid.NewGuid();
            private static Exception _exception;

            Establish that = () =>
                The<IQueryDispatcher>()
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