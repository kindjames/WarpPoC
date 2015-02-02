using System;
using hGem.Core.Services.Dtos.Customer;

namespace hGem.Core.Services
{
    public interface ICustomerService
    {
        CustomerDto GetCustomerForUser(Guid userId);
    }
}