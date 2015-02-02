using System;

namespace hGem.Core.Services.TextResourceService
{
    public interface ILanguageService
    {
        Guid GetBrowserLanguageIdForInvariantCulture(string invariantCulture);
    }
}
