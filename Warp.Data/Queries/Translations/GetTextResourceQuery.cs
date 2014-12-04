using System.Linq;
using Warp.Core.Query;
using Warp.Core.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Translations
{
    public sealed class GetTextResourceQuery : IQuery<Translation>
    {
        [IdRequired]
        public int TextResourceId { get; set; }

        [IdRequired]
        public int LanguageIdType { get; set; }

        public int ClientId { get; set; }
    }

    public sealed class GetTranslationQueryHandler : IQueryHandler<GetTextResourceQuery, Translation>
    {
        private readonly IHospitalityGemDbContext _context;

        public GetTranslationQueryHandler(IHospitalityGemDbContext context)
        {
            _context = context;
        }

        public Translation Execute(GetTextResourceQuery query)
        {
            return _context.Translations
                .SingleOrDefault(t =>
                    t.ClientID == query.ClientId && t.ApplicationLanguageID == query.LanguageIdType &&
                    t.TextResourceID == query.TextResourceId);
        }
    }
}