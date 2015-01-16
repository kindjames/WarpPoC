using System;
using Warp.Core.Command;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Util;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Core.Services.TextResourceService;
using Warp.Core.Services.UserService;
using Warp.Data.Commands.TextResources;
using Warp.Data.Queries.TextResources;

namespace Warp.Services
{
    public class TextResourceService : ITextResourceService
    {
        private readonly ILanguageService _languageService;
        private readonly IUserService _userService;
        private readonly IDispatcher _dispatcher;
        private readonly IObjectMapper _objectMapper;

        public TextResourceService(ILanguageService languageService, IUserService userService, IDispatcher dispatcher, IObjectMapper objectMapper)
        {
            _languageService = languageService;
            _userService = userService;
            _dispatcher = dispatcher;
            _objectMapper = objectMapper;
        }

        #region In Process

        public string GetTextResource(Guid textResourceCodeId)
        {
            CheckArgument.NotEmptyGuid(textResourceCodeId, "textResourceCodeId");

            return _dispatcher.Execute(new GetTextResourceQuery { TextResourceIdentifierId = textResourceCodeId });
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

            var textResourceString = _dispatcher.Execute(new GetTextResourceStringQuery { TextResourceIdentifierId = textResourceIdentifierId });

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
            CheckArgument.NotEmptyGuid(textResourceCodeId, "textResourceCodeId");

            string textResourceCode = _dispatcher.Execute(new GetTextResourceCodeQuery { TextResourceCodeId = textResourceCodeId });

            CheckArgument.NotEmpty(textResourceCode, "textResourceCode");

            return new ResourceCodeDto
            {
                TextResourceCode = textResourceCode
            };
        }

        public void SaveTextResource(SaveTextResourceDto saveTextResourceDto)
        {
            CheckArgument.NotNull(saveTextResourceDto, "SaveTextResourceDto");
            
            // Validate SaveTextResourceDto data
            // Validate ResourceString
            // if(ValidateResourceStringQuery)
            // {

            // }


            // ValidateResourceDataQuery
                // Validate ResourceIdentifier
            
            // Validate ResourceIdentifierCode
                // Throw exception()

            // Validate ResourceString
                // Throw exception()
            
            // Yes. Continue with Save.  

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
            //var stringExists = _dispatcher.Execute(DuplicateResourceStringExistsQuery);
            //if (!(_dispatcher.Execute(textResourceStringQuery)) && !(_dispatcher.Execute(textResourceCodeQuery)))
        }


        /// <summary>
        ///  TODO -> Validate unique ResourceString
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool GetResourceString(string textResourceString)
        {
            return true; //_dispatcher.Execute(DuplicateResourceStringExistsQuery(dto));
        }

        /// <summary>
        ///  TODO -> Validate unique ResourceCode
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool CheckResourceCodeExists(string textResourceCode)
        {
            // Get Associated TextResource data(Query on , populate and return DuplicateTextResourceDto to User(ResourceIdentifier and associated TextResource dto)
            return true;
        }


        #endregion Next


        public ResourceCodeDto GetTextResourceCode(int textResourceCodeId)
        {

            throw new NotImplementedException();
        }

        public bool InitializeTextResourceCache(int languageId, int clientId = 0)
        {
            // InitResourceCacheQuery

            throw new NotImplementedException();
        }
    }
}
