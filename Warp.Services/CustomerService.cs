using Warp.Core.Infrastructure.Mapping;
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
        private readonly IObjectMapper _objectMapper;

        public CustomerService(IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public CustomerDto GetCustomerForUser(int userId)
        {
            CheckArgument.NotZero(userId, "userId");

            var customer = _queryDispatcher.Execute(new GetCustomerForUserQuery {UserId = userId});

            return _objectMapper.Map<Customer, CustomerDto>(customer);
        }
    }
}