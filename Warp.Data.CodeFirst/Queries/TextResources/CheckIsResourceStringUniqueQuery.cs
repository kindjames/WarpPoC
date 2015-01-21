using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public class CheckIsResourceStringUniqueQuery : IQuery<bool>
    {
        [Required]
        public string ResourceString { get; set; }

        [Required]
        public Guid UserLanguageId { get; set; }

        [Required]
        public bool ClientOverridable { get; set; }

        public Guid ClientId { get; set; }

        public CheckIsResourceStringUniqueQuery()
        {   
            ClientOverridable = false;
            ClientId = Guid.Empty;
        }
    }

    public class CheckIsResourceStringAssignedQueryHandler : IQueryHandler<CheckIsResourceStringUniqueQuery, bool>
    {
        private readonly ITextResourceDbContext _dbContext;

        public CheckIsResourceStringAssignedQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Handle(CheckIsResourceStringUniqueQuery query)
        {
            bool result;

            if (query.ClientOverridable && query.ClientId != Guid.Empty)
                {
                    /// Client overridable with override
                    result = _dbContext.TextResources
                        .Any(tr =>
                            tr.ResourceString == query.ResourceString &&
                            tr.LanguageId == query.UserLanguageId &&
                            tr.ClientId == query.ClientId);
                }
                else
                {
                    /// Client overridable with no override
                    result = _dbContext.TextResources
                        .Any(tr =>
                            tr.ResourceString == query.ResourceString &&
                            tr.LanguageId == query.UserLanguageId);
                }


            return result;
        }
    }
}