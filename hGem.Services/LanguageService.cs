using System;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.Util;
using hGem.Core.Services.TextResourceService;
using hGem.Data.Queries.Languages;

namespace hGem.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IDispatcher _dispatcher;

        public LanguageService(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public Guid GetBrowserLanguageIdForInvariantCulture(string invariantCulture)
        {
            CheckArgument.NotEmpty(invariantCulture, "invariantCulture");

            var languageId = _dispatcher.Execute(new GetLanguageIdByInvariantCultureQuery { InvariantCulture = invariantCulture });
            
            if (languageId != Guid.Empty)
            {
                return languageId;
            }

            // If the Browser language is not supported, degrade gracefully to English.
            return _dispatcher.Execute(new GetLanguageIdByInvariantCultureQuery { InvariantCulture = "en" });
        }
    }
}