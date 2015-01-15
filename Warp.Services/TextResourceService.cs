using System;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Query;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Core.Services.TextResourceService;
using Warp.Core.Services.UserService;
using Warp.Core.Util;
using Warp.Data.Queries.TextResources;

namespace Warp.Services
{
    public class TextResourceService : ITextResourceService
    {
        private readonly ILanguageService _languageService;
        private readonly IUserService _userService;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public TextResourceService(ILanguageService languageService, IUserService userService, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _languageService = languageService;
            _userService = userService;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        #region In Process

        public string GetTextResource(Guid textResourceCodeId)
        {
            CheckArgument.NotEmptyGuid(textResourceCodeId, "textResourceCodeId");

            return _queryDispatcher.Execute(new GetTextResourceQuery { TextResourceIdentifierId = textResourceCodeId });
        }

        public string GetTextResourceFromCode(string textResourceCode)
        {
            return textResourceCode;
        }

        #endregion In Process

        #region Next

        public ResourceStringDto GetTextResourceString(Guid textResourceIdentifierId)
        {
            CheckArgument.NotEmptyGuid(textResourceIdentifierId, "textResourceIdentifierId");

            var textResourceString = _queryDispatcher.Execute(new GetTextResourceStringQuery { TextResourceIdentifierId = textResourceIdentifierId });

            if (String.IsNullOrWhiteSpace(textResourceString))
            {
                return null;
            }

            return new ResourceStringDto
            {
                TextResourceString = textResourceString
            };
        }

        public ResourceCodeDto GetTextResourceCode(Guid textResourceCodeId)
        {
            CheckArgument.NotEmptyGuid(textResourceCodeId, "textResourceCodeId");

            string textResourceCode = _queryDispatcher.Execute(new GetTextResourceCodeQuery { TextResourceCodeId = textResourceCodeId });

            CheckArgument.NotEmpty(textResourceCode, "textResourceCode");

            return new ResourceCodeDto
            {
                TextResourceCode = textResourceCode
            };
        }

        public void SaveResource(SaveTextResourceDto saveTextResourceDto)
        {
            //    CheckArgument.NotNull(saveTextResourceDto, "saveTextResourceDto");


            //var stringExists = _queryDispatcher.Execute(DuplicateResourceStringExistsQuery);


            //var codeExists = ValidateResourceCode(new TextResourceCodeDto { TextResourceCode = model.TextResourceCode });

            // Inverted check. If both true then neither phrases exist in the database so safe to save and commit new TextResource
            //if (!(_queryDispatcher.Execute(textResourceStringQuery)) && !(_queryDispatcher.Execute(textResourceCodeQuery)))
            //{

            //}


            // Verify that the TextResourceString to Save does not already exist.
            //  If it exists, Query both tables for associated data and return DTO to User
            // Verify that the TextResourceCode has not already been assigned to another TextResourceString
        }


        public bool ValidateResourceString(ResourceStringDto dto)
        {
            return true; //_queryDispatcher.Execute(DuplicateResourceStringExistsQuery(dto));
        }

        public bool ValidateResourceCode(ResourceCodeDto dto)
        {
            throw new NotImplementedException();
        }


        #endregion Next
    }
}
