
using Warp.Core.Services.Dtos.TextResources;

namespace Warp.Core.Services.TextResourceService
{
    public interface ITextResourceService
    {
        string GetTextResource(int textResourceCodeId);
        ResourceStringDto GetTextResourceString(int textResourceCodeId);
        ResourceCodeDto GetResourceIdentifierCode(int textResourceCodeId);

        bool ValidateResourceString(ResourceStringDto dto);
        bool ValidateResourceCode(ResourceCodeDto dto);

        void SaveResource(SaveTextResourceDto saveTextResourceDto);
    }
}