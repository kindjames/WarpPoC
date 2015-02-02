using System;
using hGem.Core.Cqrs;
using hGem.Core.Exceptions.Data;
using hGem.Core.Infrastructure.AutoMapper;
using hGem.Core.Services;
using hGem.Core.Services.Dtos.Brand;
using hGem.Data.Entities;
using hGem.Data.Queries.Brands;
using hGem.Data.Queries.Customers;
using hGem.Data.Queries.General;

namespace hGem.Services
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