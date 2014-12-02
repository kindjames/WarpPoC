
using Warp.Core.Query;
using Warp.Core.Services.Dtos.TextResources;

namespace Warp.Core.Services.TextResourceService
{
    public interface ITextResourceService
    {
        string GetTextResourceString(int textResourceId);
        TextResourceStringDto GetTextResource(int textResourceCodeId);
        TextResourceCodeDto GetTextResourceCode(int textResourceCodeId);

        bool ValidateResourceString(TextResourceStringDto dto);
        bool ValidateResourceCode(TextResourceCodeDto dto);

        void SaveResource(SaveTextResourceDto saveTextResourceDto);
    }
}