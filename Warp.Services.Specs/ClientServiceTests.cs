using Machine.Fakes;
using Machine.Specifications;
using System;
using System.Collections.Generic;
using Warp.Core.Exceptions;
using Warp.Core.Query;
using Warp.Core.Services.Dtos.Client;
using Warp.Data.Models;
using Warp.Data.Queries.Brands;
using MoqIt = Moq.It;
using ThenIt = Machine.Specifications.It;

namespace Warp.Services.Specs
{
    [Subject("Client Service")]
    public class ClientServiceTests
    {
        public class When_getting_brand_summary_list_for_client_that_does_not_exist : WithSubject<ClientService>
        {
            private static Exception _exception;

            Establish that = () =>
                The<IQueryDispatcher>()
                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<GetBrandsForClientQuery>()))
                    .Return((IEnumerable<Brand>)null);

            Because of = () => _exception = Catch.Exception(() => Subject.SaveClient(new SaveClientDto()));

            ThenIt should_error = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ClientNotFoundException>();
            };
        }
    }
}