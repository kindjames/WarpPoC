using System;
using hGem.Core.Services.Dtos.TextResources;

namespace hGem.Core.Services.TextResourceService
{
    public interface ITextResourceService
    {
        string GetTextResource(Guid textResourceCodeId);
        string GetTextResourceFromCode(string textResourceCode);

        void SaveTextResource(SaveTextResourceDto saveTextResourceDto); // retuns IResponse<TextResourceDetailDto>
    }
}