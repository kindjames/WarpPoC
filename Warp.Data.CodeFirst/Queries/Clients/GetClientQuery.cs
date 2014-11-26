using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Clients
{
    public class GetClientQuery : IQuery<Client>
    {
        [IdRequired]
        public int ClientId { get; set; }
    }

    public class GetClientQueryHandler : IQueryHandler<GetClientQuery, Client>
    {
        private readonly IDomainDbContext _dbContext;

        public GetClientQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Client Execute(GetClientQuery query)
        {
            return _dbContext.Clients
                .SingleOrDefault(b => b.ClientId == query.ClientId);
        }
    }
}