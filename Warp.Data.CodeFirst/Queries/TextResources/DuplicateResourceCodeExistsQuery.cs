using System.ComponentModel.DataAnnotations;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public class DuplicateResourceCodeExistsQuery : IQuery<bool>
    {
        [Required]
        public string ResourceCode { get; set; }
    }

    public class DuplicateResourceCodeExistsQueryHandler : IQueryHandler<DuplicateResourceCodeExistsQuery, bool>
    {
        private readonly ITextResourceDbContext _dbContext;

        public DuplicateResourceCodeExistsQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Handle(DuplicateResourceCodeExistsQuery query)
        {
            return _dbContext.TextResourceIdentifiers
                .Any(trc => trc.TextResourceCode == query.ResourceCode);
        }
    }
}