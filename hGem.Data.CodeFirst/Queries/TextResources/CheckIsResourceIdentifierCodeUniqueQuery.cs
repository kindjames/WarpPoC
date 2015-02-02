﻿using System.ComponentModel.DataAnnotations;
using System.Linq;
using hGem.Core.Cqrs;
using hGem.Data.Context;

namespace hGem.Data.Queries.TextResources
{
    public class CheckIsResourceIdentifierCodeUniqueQuery : IQuery<bool>
    {
        [Required]
        public string ResourceIdentifierCode { get; set; }

        public CheckIsResourceIdentifierCodeUniqueQuery query { get; set; }

        public CheckIsResourceIdentifierCodeUniqueQuery()
        {
            query = new CheckIsResourceIdentifierCodeUniqueQuery
            {
                
            };
        }
    }

    public class CheckIsResourceIdentifierCodeUniqueQueryHandler : IQueryHandler<CheckIsResourceIdentifierCodeUniqueQuery, bool>
    {
        private readonly ITextResourceDbContext _dbContext;

        public CheckIsResourceIdentifierCodeUniqueQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Handle(CheckIsResourceIdentifierCodeUniqueQuery query)
        {
            return _dbContext.TextResourceIdentifiers
                .Any(tri => tri.ResourceIdentifierCode == query.ResourceIdentifierCode);
        }
    }
}