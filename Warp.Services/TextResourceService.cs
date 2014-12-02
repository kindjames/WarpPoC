using Warp.Core.Services;
using Warp.Core.Services.TextResourceService;

namespace Warp.Services
{
    public sealed class TextResourceService : ITextResourceService
    {
        public string GetTextResourceString(int textResourceId)
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


        public Core.Services.Dtos.TextResources.TextResourceStringDto GetTextResource(int textResourceCodeId)
        {
            throw new System.NotImplementedException();
        }

        public Core.Services.Dtos.TextResources.TextResourceCodeDto GetTextResourceCode(int textResourceCodeId)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidateResourceString(Core.Services.Dtos.TextResources.TextResourceStringDto dto)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidateResourceCode(Core.Services.Dtos.TextResources.TextResourceCodeDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void SaveResource(Core.Services.Dtos.TextResources.SaveTextResourceDto saveTextResourceDto)
        {
            throw new System.NotImplementedException();
        }
    }
}