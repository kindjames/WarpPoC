using System;
using Warp.Core.Command;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Query;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Core.Services.TextResourceService;
using Warp.Core.Services.UserService;
using Warp.Core.Util;
using Warp.Data.Commands.TextResources;
using Warp.Data.Queries.TextResources;

namespace Warp.Services
{
    public class TextResourceService : ITextResourceService
    {
        private readonly ILanguageService _languageService;
        private readonly IUserService _userService;
        readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public TextResourceService(ILanguageService languageService, IUserService userService, ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _languageService = languageService;
            _userService = userService;
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        #region In Process

        public string GetTextResource(int textResourceCodeId)
        {
            CheckArgument.NotZero(textResourceCodeId, "textResourceCodeId");

            return _queryDispatcher.Execute(new GetTextResourceQuery { TextResourceIdentifierId = textResourceCodeId });
        }

        #endregion In Process

        #region Next

        public ResourceStringDto GetTextResourceString(int textResourceIdentifierId)
        {
            CheckArgument.NotZero(textResourceIdentifierId, "textResourceIdentifierId");

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

        public ResourceCodeDto GetResourceIdentifierCode(int textResourceCodeId)
        {
            CheckArgument.NotZero(textResourceCodeId, "textResourceCodeId");

            string textResourceCode = _queryDispatcher.Execute(new GetTextResourceCodeQuery { TextResourceCodeId = textResourceCodeId });

            CheckArgument.NotEmpty(textResourceCode, "textResourceCode");

            return new ResourceCodeDto
            {
                TextResourceCode = textResourceCode
            };
        }

        public void SaveResource(SaveTextResourceDto saveTextResourceDto)
        {
            CheckArgument.NotNull(saveTextResourceDto, "SaveTextResourceDto");

            // New Resource
            if (saveTextResourceDto.Id == 0)
            {
                var command = _objectMapper.Map<SaveTextResourceDto, SaveTextResourceCommand>(saveTextResourceDto);
                
                _commandDispatcher.Execute(command);

                saveTextResourceDto.Id = command.Id;
            }
            // Update existing Resource
            else
            {
                var command = _objectMapper.Map<SaveTextResourceDto, UpdateTextResourceCommand>(saveTextResourceDto);
                _commandDispatcher.Execute(command);
            }


            //var validateNewTextResourceQuery = new 
            // Create and populate NewTextResourceDto object

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

        /// <summary>
        ///  TODO -> Validate unique ResourceString
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool ValidateResourceString(ResourceStringDto dto)
        {
            return true; //_queryDispatcher.Execute(DuplicateResourceStringExistsQuery(dto));
        }

        /// <summary>
        ///  TODO -> Validate unique ResourceCode
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool ValidateResourceCode(ResourceCodeDto dto)
        {
            throw new NotImplementedException();
        }


        #endregion Next


        public ResourceCodeDto GetTextResourceCode(int textResourceCodeId)
        {
            throw new NotImplementedException();
        }
    }
}
