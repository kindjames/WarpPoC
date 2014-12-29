using AutoMapper;
using Warp.Core.Query;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Customer;
using Warp.Core.Util;
using Warp.Data.Entities;
using Warp.Data.Queries.Customers;

namespace Warp.Services
{
    public sealed class CustomerService : ICustomerService
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IMappingEngine _mappingEngine;

        public CustomerService(IQueryDispatcher queryDispatcher, IMappingEngine mappingEngine)
        {
            _queryDispatcher = queryDispatcher;
            _mappingEngine = mappingEngine;
        }

        public CustomerDto GetCustomerForUser(int userId)
        {
            CheckArgument.NotZero(userId, "userId");

            var customer = _queryDispatcher.Execute(new GetCustomerForUserQuery {UserId = userId});

            return _mappingEngine.Map<Customer, CustomerDto>(customer);
        }
    }
}