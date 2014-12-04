using Warp.Core.Services.Dtos.Customer;

namespace Warp.Core.Services
{
    public interface ICustomerService
    {
        CustomerDto GetCustomerForUser(int userId);
    }
}