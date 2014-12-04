
namespace Warp.Core.Services.TextResourceService
{
    public interface ILanguageService
    {
        int GetBrowserLanguageIdForInvariantCulture(string invariantCulture);
    }
}
