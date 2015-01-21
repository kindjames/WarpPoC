using System;
using Warp.Core.Services.Dtos.TextResources;

namespace Warp.Core.Services.TextResourceService
{
    public interface ITextResourceService
    {
        string GetTextResource(Guid textResourceCodeId);
        string GetTextResourceFromCode(string textResourceCode);
        
        IResponse<TextResourceDetailDto> SaveTextResource(SaveTextResourceDto saveTextResourceDto);
    }
}