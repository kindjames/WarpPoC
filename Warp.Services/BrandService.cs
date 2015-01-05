using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Query;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Brand;
using Warp.Data.Entities;
using Warp.Data.Exceptions;
using Warp.Data.Queries.Brands;
using Warp.Data.Queries.Clients;
using Warp.Data.Queries.Customers;

namespace Warp.Services
{
    public class BrandService : IBrandService
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public BrandService(IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public BrandSummaryListDto GetBrandSummaryListForClient(int clientId)
        {
            var client = _queryDispatcher.Execute(new GetClientQuery {ClientId = clientId});

            if (client == null)
            {
                throw new DataEntityNotFoundException<Client>(clientId);
            }

            var brands = _queryDispatcher.Execute(new GetBrandsForClientQuery {ClientId = clientId});

            var customerName = _queryDispatcher.Execute(new GetCustomerNameQuery {CustomerId = client.Customer.Id});

            return new BrandSummaryListDto
            {
                Brands = _objectMapper.MapMany<Brand, BrandSummaryDto>(brands),
                CustomerName = customerName,
                ClientName = client.Name
            };
        }
    }
}