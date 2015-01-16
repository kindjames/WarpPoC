using System;
using Warp.Core.Cqrs;
using Warp.Core.Services.TextResourceService;
using Warp.Core.Util;
using Warp.Data.Queries.Languages;

namespace Warp.Services
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