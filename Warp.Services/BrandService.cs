using System.Collections.Generic;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure;
using Warp.Core.Query;
using Warp.Core.Services;
using Warp.Core.Services.Dtos;
using Warp.Core.Services.Dtos.Brand;
using Warp.Data.Queries.Brands;
using Warp.Data.Queries.Clients;
using Warp.Data.Queries.Customers;

namespace Warp.Services
{
    public class BrandService : IBrandService
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IMapper _mapper;

        public BrandService(IQueryDispatcher queryDispatcher, IMapper mapper)
        {
            _queryDispatcher = queryDispatcher;
            _mapper = mapper;
        }

        public BrandSummaryListDto GetBrandSummaryListForClient(int clientId)
        {
            var client = _queryDispatcher.Execute(new GetClientQuery {ClientId = clientId});

            if (client == null)
            {
                throw new ClientNotFoundException(clientId);
            }

            var brands = _queryDispatcher.Execute(new GetBrandsForClientQuery {ClientId = clientId});

            var customerName = _queryDispatcher.Execute(new GetCustomerNameQuery {CustomerId = client.CustomerID});
            
            return new BrandSummaryListDto
            {
                Brands = _mapper.Map<IEnumerable<BrandSummaryDto>>(brands),
                CustomerName = customerName,
                ClientName = client.Name,
            };
        }
    }
}