using System.Linq;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.Clients
{
    public class CheckClientExistsForCodeQuery : IQuery<bool>
    {
        public string ClientCode { get; set; }
        public int CustomerId { get; set; }
    }

    public class CheckClientExistsForCodeQueryHandler : IQueryHandler<CheckClientExistsForCodeQuery, bool>
    {
        private readonly IHospitalityGemDbContext _dbContext;

        public CheckClientExistsForCodeQueryHandler(IHospitalityGemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Execute(CheckClientExistsForCodeQuery query)
        {
            return _dbContext.Clients
                .Any(c => c.CustomerID == query.CustomerId && c.Code == query.ClientCode);
        }
    }
}