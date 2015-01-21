using System;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Util;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Customer;
using Warp.Data.Entities;
using Warp.Data.Queries.Customers;

namespace Warp.Services
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