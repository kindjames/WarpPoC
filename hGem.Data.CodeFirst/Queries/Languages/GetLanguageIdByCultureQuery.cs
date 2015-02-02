using System;
using System.Linq;
using hGem.Core.Cqrs;
using hGem.Data.Context;

namespace hGem.Data.Queries.Languages
{
    public sealed class GetLanguageIdByInvariantCultureQuery : IQuery<Guid>
    {
        public string InvariantCulture { get; set; }
    }

    public sealed class GetLanguageIdByInvariantCultureQueryHandler : IQueryHandler<GetLanguageIdByInvariantCultureQuery, Guid>
    {
        private readonly ITextResourceDbContext _dbContext;

        public GetLanguageIdByInvariantCultureQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Guid Handle(GetLanguageIdByInvariantCultureQuery query)
        {
            return _dbContext.Languages
                .Where(l => l.InvariantCulture == query.InvariantCulture)
                .Select(l => l.Id)
                .SingleOrDefault();
        }
    }
}