using System.ComponentModel.DataAnnotations;
using System.Linq;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public class ValidateUniqueResourceCodeQuery : IQuery<bool>
    {
        [Required]
        public string ResourceIdentifierCode { get; set; }
    }

    public class ValidateUniqueResourceCodeQueryHandler : IQueryHandler<ValidateUniqueResourceCodeQuery, bool>
    {
        readonly ITextResourceDbContext _dbContext;

        public ValidateUniqueResourceCodeQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Execute(ValidateUniqueResourceCodeQuery query)
        {
            return _dbContext.TextResourceIdentifiers
                .Any(tri => tri.TextResourceCode == query.ResourceIdentifierCode);
        }
    }
}