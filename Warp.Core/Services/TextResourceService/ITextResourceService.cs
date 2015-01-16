using System;
using Warp.Core.Services.Dtos.TextResources;

namespace Warp.Core.Services.TextResourceService
{
    public interface ITextResourceService
    {
        string GetTextResource(Guid textResourceCodeId);
        string GetTextResourceFromCode(string textResourceCode);
        ResourceStringDto GetTextResourceString(Guid textResourceCodeId);
        ResourceCodeDto GetTextResourceCode(Guid textResourceCodeId);

        bool ValidateResourceString(ResourceStringDto dto);
        bool ValidateResourceCode(ResourceCodeDto dto);

        void SaveResource(SaveTextResourceDto saveTextResourceDto);
    }
}