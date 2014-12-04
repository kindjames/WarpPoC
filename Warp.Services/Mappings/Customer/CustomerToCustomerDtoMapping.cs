using System;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services.Dtos.Customer;

namespace Warp.Services.Mappings.Customer
{
    public class CustomerToCustomerDtoMapping : IMappingConfiguration<Data.Entities.Customer, CustomerDto>
    {
        public CustomerDto Map(Data.Entities.Customer source)
        {
            return new CustomerDto
            {
                CustomerId = source.CustomerId,
                CustomerCode = source.CustomerCode,
                Name = source.Name,
                DisplayName = source.DisplayName,
                Uri = new Uri(source.UrlName),
            };
        }
    }
}