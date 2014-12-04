﻿using System;
using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Customers;

namespace Warp.Data.Specs.Queries.Customers
{
    [Subject("Get Customer Query Handler")]
    public class GetCustomerQueryHandlerTests
    {
        public class When_querying_for_customer_and_customer_does_not_exist : WithSubject<GetCustomerQueryHandler>
        {
            const int CustomerId = 100;
            static Customer _result;

            Establish that = () =>
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Customers)
                    .Return(new InMemoryDbSet<Customer>(true)
                    {
                        new Customer {CustomerId = 123}
                    });

            Because of = () => _result = Subject.Execute(new GetCustomerQuery { CustomerId = CustomerId });

            It should_return_a_null_Customer = () =>
                _result.ShouldBeNull();
        }

        public class When_querying_for_customer_that_exists : WithSubject<GetCustomerQueryHandler>
        {
            const int CustomerId = 100;
            static Customer _result;
            static string _customerName;

            Establish that = () =>
            {
                _customerName = Guid.NewGuid().ToString();

                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Customers)
                    .Return(new InMemoryDbSet<Customer>(true)
                    {
                        new Customer {CustomerId = CustomerId, Name = _customerName}
                    });
            };

            Because of = () => _result = Subject.Execute(new GetCustomerQuery { CustomerId = CustomerId });

            It should_return_the_customer = () =>
            {
                _result.ShouldNotBeNull();
                _result.Name.ShouldEqual(_customerName);
            };
        }
    }
}