﻿using System;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public sealed class GetTextResourceQuery : IQuery<string>
    {
        [IdRequired]
        public Guid TextResourceIdentifierId { get; set; }
    }

    public sealed class GetTextResourceQueryHandler : IQueryHandler<GetTextResourceQuery, string>
    {
        readonly ITextResourceDbContext _context;

        public GetTextResourceQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public string Handle(GetTextResourceQuery query)
        {
            // TODO: JK -> PG Does this need to filter on language too?
            return _context.TextResources
                    .Where(t => t.TextResourceIdentifier.Id == query.TextResourceIdentifierId)
                    .Select(t => t.ResourceString)
                    .SingleOrDefault();
        }
    }
}