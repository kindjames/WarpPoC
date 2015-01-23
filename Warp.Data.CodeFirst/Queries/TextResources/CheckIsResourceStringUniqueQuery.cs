using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public class CheckIsResourceStringUniqueQuery : IQuery<bool>
    {
        [Required]
        public string ResourceString { get; set; }

        [Required]
        public Guid UserLanguageId { get; set; }

        public bool ClientOverridable { get; set; }

        public Guid ClientId { get; set; }

        public CheckIsResourceStringUniqueQuery()
        {
            ClientId = Guid.Empty;
        }
    }

    public sealed class CheckIsResourceStringUniqueQueryValidator : AbstractValidator<CheckIsResourceStringUniqueQuery>
    {
        public CheckIsResourceStringUniqueQueryValidator()
        {
            RuleFor(q => q.ResourceString).NotEmpty();
            RuleFor(q => q.UserLanguageId).NotEmptyGuid();
        }
    }

    public class CheckIsResourceStringUniqueQueryHandler : IQueryHandler<CheckIsResourceStringUniqueQuery, bool>
    {
        private readonly ITextResourceDbContext _dbContext;

        public CheckIsResourceStringUniqueQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Handle(CheckIsResourceStringUniqueQuery query)
        {
            bool result;

            if (query.ClientOverridable && query.ClientId != Guid.Empty)
                {
                    /// Return Client specific TextResource (Client overridable with override)
                    result = _dbContext.TextResources
                        .Any(tr =>
                            tr.ResourceString == query.ResourceString &&
                            tr.LanguageId == query.UserLanguageId &&
                            tr.ClientId == query.ClientId);
                }
                else
                {
                    /// Case => (Not Client overridable) or (Client overridable with no override)
                    result = _dbContext.TextResources
                        .Any(tr =>
                            tr.ResourceString == query.ResourceString &&
                            tr.LanguageId == query.UserLanguageId);
                }


            return result;
        }
    }
}