using Warp.Core.Services;

namespace Warp.Services
{
    public sealed class TextResourceService : ITextResourceService
    {
        public string GetTextResource(int textResourceId)
        {
            return "HELLO WORLD.";
        }
    }
}