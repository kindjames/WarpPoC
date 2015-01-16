using System;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Clients
{
    public class GetClientQuery : IQuery<Client>
    {
        [IdRequired]
        public Guid ClientId { get; set; }
    }

    public class GetClientQueryHandler : IQueryHandler<GetClientQuery, Client>
    {
        private readonly IDomainDbContext _dbContext;

        public GetClientQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Client Handle(GetClientQuery query)
        {
            return _dbContext.Clients
                .SingleOrDefault(b => b.Id == query.ClientId);
        }
    }
}