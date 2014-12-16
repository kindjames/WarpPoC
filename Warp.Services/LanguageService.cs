using Warp.Core.Query;
using Warp.Core.Services.TextResourceService;
using Warp.Core.Util;
using Warp.Data.Queries.Languages;

namespace Warp.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IQueryDispatcher _queryDispatcher;

        public LanguageService(IQueryDispatcher queryDispatcher)
        {
            _queryDispatcher = queryDispatcher;
        }

        public int GetBrowserLanguageIdForInvariantCulture(string invariantCulture)
        {
            CheckArgument.NotEmpty(invariantCulture, "invariantCulture");

            var languageId = _queryDispatcher.Execute(new GetLanguageIdByInvariantCultureQuery { InvariantCulture = invariantCulture });
            
            if (languageId > 0)
            {
                return languageId;
            }

            // If the Browser language is not supported, degrade gracefully to English.
            return 1;
        }
    }
}