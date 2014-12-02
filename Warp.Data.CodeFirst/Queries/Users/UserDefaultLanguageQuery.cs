using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.Users
{
    public class UserDefaultLanguageQuery : IQuery<int>
    {
        [IdRequired]
        public int UserId { get; set; }
    }

    public class GetDefaultLanguageForUserQueryHandler : IQueryHandler<UserDefaultLanguageQuery, int>
    {
        private readonly ITextResourceDbContext _dbContext;
        
        public GetDefaultLanguageForUserQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Execute(UserDefaultLanguageQuery query)
        {
            return _dbContext.Users
                .Where(u => u.UserId == query.UserId)
                .Select(u => u.DefaultLanguageId)
                .SingleOrDefault();
        }
    }
}