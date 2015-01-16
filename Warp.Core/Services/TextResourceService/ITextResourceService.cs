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

        /// <summary>
        /// TODO -> SaveTextResource
        /// </summary>
        /// <param name="saveTextResourceDto"></param>
        void SaveTextResource(SaveTextResourceDto saveTextResourceDto);
        
        /// <summary>
        /// TODO -> Validate unique ResourceString
        /// </summary>
        /// <param name="textResourceString"></param>
        /// <returns>bool</returns>
        bool CheckResourceStringExists(string textResourceString);

        /// <summary>
        ///  TODO -> Validate unique ResourceCode
        /// </summary>
        /// <param name="textResourceCode"></param>
        /// <returns>bool</returns>
        bool CheckResourceCodeExists(string textResourceCode);
    }
}