using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Data.Context;

namespace Warp.Data.Queries.Languages
{
    public sealed class ResolveBrowserLanguageQuery : IQuery<Guid>
    {
        [Required]
        public string InvariantCulture { get; set; }
    }

    public sealed class ResolveBrowserLanguageQueryHandler : IQueryHandler<ResolveBrowserLanguageQuery, Guid>
    {
        private readonly ITextResourceDbContext _dbContext;

        public ResolveBrowserLanguageQueryHandler(ITextResourceDbContext context)
        {
            _dbContext = context;
        }

        public Guid Handle(ResolveBrowserLanguageQuery query)
        {
            return _dbContext.Languages
                .Where(lang => lang.InvariantCulture == query.InvariantCulture)
                .Select(i => i.Id)
                .SingleOrDefault();
        }
    }
}
