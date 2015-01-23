using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Cqrs;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Clients;

namespace Warp.Data.Queries.TextResources
{
    public class GetAssociatedTextResourceDataQuery : IQuery<TextResourceDetailDto>
    {   
        public string ResourceString { get; set; }

        public string ResourceIdentifierCode { get; set; }
    }

    public class GetAssociatedTextResourceDataQueryHandler : IQueryHandler<GetAssociatedTextResourceDataQuery, TextResourceDetailDto>
    {
        private readonly ITextResourceDbContext _dbContext;

        public GetAssociatedTextResourceDataQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TextResourceDetailDto Handle(GetAssociatedTextResourceDataQuery query)
        {
            var textResource = _dbContext.TextResources
                .SingleOrDefault(tr => tr.ResourceString == query.ResourceString);

            var textResourceIdentifier = _dbContext.TextResourceIdentifiers
                .SingleOrDefault(tri => tri.Id == textResource.ResourceIdentifierId);

            string clientName = "";

            /// Resolve associated Client data if Client overridden
            if (textResourceIdentifier.ClientOverridable)
            {
                if (textResource.ClientId != Guid.Empty)
                {
                    clientName = textResource.Client.Name;
                }
                else
                {
                    clientName = "No Client override";
                }
            }


            return new TextResourceDetailDto
            {
                // TextResources
                ResourceString = textResource.ResourceString,
                ResourceIdentifierCode = textResourceIdentifier.ResourceIdentifierCode,

                LanguageName = textResource.Language.Name,

                LanguageCulture = String.Concat("{0}" + " - " +"{1}", textResource.Language.InvariantCulture, textResource.Language.Locale),

                ClientName = clientName,
            };
        }
    }
}
