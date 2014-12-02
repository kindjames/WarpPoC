using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;
using Warp.Data.Queries.Users;

namespace Warp.Data.Queries.TextResources
{
    public sealed class ResolveUserLanguageQuery : IQuery<int>
    {
        [IdRequired]
        public int UserId { get; set; }
    }

    public sealed class UserDefaultLanguageQueryHandler : IQueryHandler<UserDefaultLanguageQuery, int>
    {
        private readonly ITextResourceDbContext _context;

        public UserDefaultLanguageQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public int Execute(UserDefaultLanguageQuery query)
        {
            return _context.Users
                .Where(u => u.UserId == query.UserId)
                .Select(u => u.DefaultLanguageId)
                .SingleOrDefault();
        }
    }
}