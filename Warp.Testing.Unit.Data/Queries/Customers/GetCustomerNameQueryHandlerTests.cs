using System;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Customers;
using Warp.Testing.Unit.Data.Commands.Clients;

namespace Warp.Testing.Unit.Data.Queries.Customers
{
    [Subject("Get CustomerId Name Query Handler")]
    public class GetCustomerNameQueryHandlerTests
    {
        public class When_querying_for_customer_and_customer_does_not_exist : WithSubject<GetCustomerNameQueryHandler>
        {
            static readonly Guid CustomerId = Guid.NewGuid();
            static string _result;

            Establish that = () =>
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Customers)
                    .Return(new TestDbSet<Customer>
                    {
                        new Customer {Id = Guid.NewGuid()}
                    });

            Because of = () => _result = Subject.Handle(new GetCustomerNameQuery { CustomerId = CustomerId });

            It should_return_a_null_string = () =>
                _result.ShouldBeNull();
        }

        public class When_querying_for_customer_that_exists : WithSubject<GetCustomerNameQueryHandler>
        {
            static readonly Guid CustomerId = Guid.NewGuid();
            static string _result;
            static string _customerName;

            Establish that = () =>
            {
                _customerName = Guid.NewGuid().ToString();

                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Customers)
                    .Return(new TestDbSet<Customer>
                    {
                        new Customer {Id = CustomerId, Name = _customerName}
                    });
            };

            Because of = () => _result = Subject.Handle(new GetCustomerNameQuery { CustomerId = CustomerId });

            It should_return_the_customers_name = () =>
                _result.ShouldEqual(_customerName);
        }
    }
}