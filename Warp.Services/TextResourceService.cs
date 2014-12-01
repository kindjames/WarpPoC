using Warp.Core.Services;

namespace Warp.Services
{
    public sealed class TextResourceService : ITextResourceService
    {
        public string GetTextResource(int textResourceId)
        {
            switch (textResourceId)
            {
                case 0:
                    return "Username";
                case 1:
                    return "E-mail or TMDC ID";
                case 2:
                    return "Password";
                case 3:
                    return "Remember me for 2 weeks";
                case 4:
                    return "Log in";
            }

            return "Resource not found for id: " + textResourceId;
        }
    }
}