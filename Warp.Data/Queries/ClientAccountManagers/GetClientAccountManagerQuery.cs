using System.Linq;
using Warp.Core.Query;
using Warp.Core.Validation;
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
        private readonly IHospitalityGemDbContext _dbContext;

        public CheckClientAccountManagerExistsQueryHandler(IHospitalityGemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Execute(CheckClientAccountManagerExistsQuery query)
        {
            return _dbContext.ClientAccountManagers
                .Any(c => c.AccountManagerID == query.AccountManagerId);
        }
    }
}