﻿using System;
using System.Linq;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.Validation;
using hGem.Data.Context;

namespace hGem.Data.Queries.Users
{
    public class GetDefaultLanguageForUserQuery : IQuery<Guid>
    {
        public Guid UserId { get; set; }
    }

    public class GetDefaultLanguageForUserQueryValidator : AbstractValidator<GetDefaultLanguageForUserQuery>
    {
        public GetDefaultLanguageForUserQueryValidator()
        {
            RuleFor(q => q.UserId).NotEmptyGuid();
        }
    }

    public class GetDefaultLanguageForUserQueryHandler : IQueryHandler<GetDefaultLanguageForUserQuery, Guid>
    {
        private readonly ITextResourceDbContext _dbContext;

        public GetDefaultLanguageForUserQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Guid Handle(GetDefaultLanguageForUserQuery query)
        {
            return _dbContext.Users
                .Where(u => u.Id == query.UserId)
                .Select(u => u.DefaultLanguageId)
                .SingleOrDefault();
        }
    }
}