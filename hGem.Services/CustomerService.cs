using System;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.AutoMapper;
using hGem.Core.Infrastructure.Util;
using hGem.Core.Services;
using hGem.Core.Services.Dtos.Customer;
using hGem.Data.Entities;
using hGem.Data.Queries.Customers;

namespace hGem.Services
{
    public sealed class CustomerService : ICustomerService
    {
        private readonly IDispatcher _dispatcher;
        private readonly IObjectMapper _objectMapper;

        public CustomerService(IDispatcher dispatcher, IObjectMapper objectMapper)
        {
            _dispatcher = dispatcher;
            _objectMapper = objectMapper;
        }

        public CustomerDto GetCustomerForUser(Guid userId)
        {
            CheckArgument.NotEmptyGuid(userId, "userId");

            var customer = _dispatcher.Execute(new GetCustomerForUserQuery {UserId = userId});

            return _objectMapper.Map<Customer, CustomerDto>(customer);
        }
    }
}