using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.ClientAccountManagers
{
    public class CheckClientAccountManagerExistsQuery : IQuery<bool>
    {
        [IdRequired]
        public int AccountManagerId { get; set; }
    }

    public class CheckClientAccountManagerExistsQueryHandler : IQueryHandler<CheckClientAccountManagerExistsQuery, bool>
    {
        private readonly IDomainDbContext _dbContext;

        public CheckClientAccountManagerExistsQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Execute(CheckClientAccountManagerExistsQuery query)
        {
            return _dbContext.ClientAccountManagers
                .Any(c => c.AccountManagerId == query.AccountManagerId);
        }
    }
}