using System;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Cqrs;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Brand;
using Warp.Data.Entities;
using Warp.Data.Queries.Brands;
using Warp.Data.Queries.Customers;
using Warp.Data.Queries.General;

namespace Warp.Services
{
    public class BrandService : IBrandService
    {
        private readonly IDispatcher _dispatcher;
        private readonly IObjectMapper _objectMapper;

        public BrandService(IDispatcher dispatcher, IObjectMapper objectMapper)
        {
            _dispatcher = dispatcher;
            _objectMapper = objectMapper;
        }

        public BrandSummaryListDto GetBrandSummaryListForClient(Guid clientId)
        {
            var client = _dispatcher.Execute(new GetEntityQuery<Client> {EntityId = clientId});

            if (client == null)
            {
                throw new DataEntityNotFoundException<Client>(clientId);
            }

            var brands = _dispatcher.Execute(new GetBrandsForClientQuery {ClientId = clientId});

            var customerName = _dispatcher.Execute(new GetCustomerNameQuery {CustomerId = client.Customer.Id});

            return new BrandSummaryListDto
            {
                Brands = _objectMapper.MapMany<Brand, BrandSummaryDto>(brands),
                CustomerName = customerName,
                ClientName = client.Name
            };
        }
    }
}