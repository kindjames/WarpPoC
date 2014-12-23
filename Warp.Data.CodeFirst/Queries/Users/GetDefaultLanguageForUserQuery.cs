using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.Users
{
    public class GetDefaultLanguageForUserQuery : IQuery<int>
    {
        [IdRequired]
        public int UserId { get; set; }
    }

    public class GetDefaultLanguageForUserQueryHandler : IQueryHandler<GetDefaultLanguageForUserQuery, int>
    {
        private readonly ITextResourceDbContext _dbContext;
        
        public GetDefaultLanguageForUserQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Execute(GetDefaultLanguageForUserQuery query)
        {
            return _dbContext.Users
                .Where(u => u.Id == query.UserId)
                .Select(u => u.DefaultLanguageId)
                .SingleOrDefault();
        }
    }
}