using System.Linq;
using Warp.Core.Query;
using Warp.Core.Validation;
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
        private readonly IHospitalityGemDbContext _dbContext;

        public GetClientQueryHandler(IHospitalityGemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Client Execute(GetClientQuery query)
        {
            return _dbContext.Clients
                .SingleOrDefault(b => b.ClientID == query.ClientId);
        }
    }
}