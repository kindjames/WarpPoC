using System;

namespace Warp.Core.Services.TextResourceService
{
    public interface ILanguageService
    {
        Guid GetBrowserLanguageIdForInvariantCulture(string invariantCulture);
    }
}
