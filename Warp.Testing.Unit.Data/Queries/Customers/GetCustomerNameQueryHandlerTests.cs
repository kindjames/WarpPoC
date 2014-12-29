using System;
using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Customers;

namespace Warp.Testing.Unit.Data.Queries.Customers
{
    [Subject("Get Customer Name Query Handler")]
    public class GetCustomerNameQueryHandlerTests
    {
        public class When_querying_for_customer_and_customer_does_not_exist : WithSubject<GetCustomerNameQueryHandler>
        {
            const int CustomerId = 100;
            static string _result;

            Establish that = () =>
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Customers)
                    .Return(new InMemoryDbSet<Customer>(true)
                    {
                        new Customer {Id = 123}
                    });

            Because of = () => _result = Subject.Execute(new GetCustomerNameQuery { CustomerId = CustomerId });

            It should_return_a_null_string = () =>
                _result.ShouldBeNull();
        }

        public class When_querying_for_customer_that_exists : WithSubject<GetCustomerNameQueryHandler>
        {
            const int CustomerId = 100;
            static string _result;
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

            Because of = () => _result = Subject.Execute(new GetCustomerNameQuery { CustomerId = CustomerId });

            It should_return_the_customers_name = () =>
                _result.ShouldEqual(_customerName);
        }
    }
}