using System;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.DbFirst.Context;

namespace Warp.Data.DbFirst.Queries.ClientAccountManagers
{
    public class CheckClientAccountManagerExistsQuery : IQuery<bool>
    {
        public Guid AccountManagerId { get; set; }
    }

    /// <summary>
    /// TODO => Validator
    /// </summary>
    
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