using System;
using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Customers;

namespace Warp.Testing.Unit.Data.Queries.Customers
{
    [Subject("Get Customer Query Handler")]
    public class GetCustomerQueryHandlerTests
    {
        public class When_querying_for_customer_and_customer_does_not_exist : WithSubject<GetCustomerQueryHandler>
        {
            static readonly Guid CustomerId = Guid.NewGuid();
            static Customer _result;

            Establish that = () =>
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Customers)
                    .Return(new InMemoryDbSet<Customer>(true)
                    {
                        new Customer {Id = Guid.NewGuid()}
                    });

            Because of = () => _result = Subject.Handle(new GetCustomerQuery { CustomerId = CustomerId });

            It should_return_a_null_Customer = () =>
                _result.ShouldBeNull();
        }

        public class When_querying_for_customer_that_exists : WithSubject<GetCustomerQueryHandler>
        {
            static readonly Guid CustomerId = Guid.NewGuid();
            static Customer _result;
            static string _customerName;

            Establish that = () =>
            {
                _customerName = Guid.NewGuid().ToString();

                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Customers)
                    .Return(new InMemoryDbSet<Customer>(true)
                    {
                        new Customer {Id = CustomerId, Name = _customerName}
                    });
            };

            Because of = () => _result = Subject.Handle(new GetCustomerQuery { CustomerId = CustomerId });

            It should_return_the_customer = () =>
            {
                _result.ShouldNotBeNull();
                _result.Name.ShouldEqual(_customerName);
            };
        }
    }
}