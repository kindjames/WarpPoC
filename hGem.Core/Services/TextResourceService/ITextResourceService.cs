using System;
using hGem.Core.Services.Dtos.TextResources;

namespace hGem.Core.Services.TextResourceService
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