﻿using System;
using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.Users
{
    public class GetDefaultLanguageForUserQuery : IQuery<Guid>
    {
        [IdRequired]
        public Guid UserId { get; set; }
    }

    public class GetDefaultLanguageForUserQueryHandler : IQueryHandler<GetDefaultLanguageForUserQuery, Guid>
    {
        private readonly ITextResourceDbContext _dbContext;
        
        public GetDefaultLanguageForUserQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Guid Execute(GetDefaultLanguageForUserQuery query)
        {
            return _dbContext.Users
                .Where(u => u.Id == query.UserId)
                .Select(u => u.DefaultLanguageId)
                .SingleOrDefault();
        }
    }
}