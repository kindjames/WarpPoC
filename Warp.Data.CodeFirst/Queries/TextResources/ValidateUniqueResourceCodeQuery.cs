using System.ComponentModel.DataAnnotations;
using System.Linq;
using Warp.Core.Cqrs;
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

        public bool Handle(ValidateUniqueResourceCodeQuery query)
        {
            return _dbContext.TextResourceIdentifiers
                .Any(tri => tri.ResourceIdentifierCode == query.ResourceIdentifierCode);
        }
    }
}