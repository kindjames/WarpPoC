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
                ResourceString = textResourceString
            };
        }

        public ResourceCodeDto GetResourceIdentifierCode(int textResourceCodeId)
        {
            CheckArgument.NotZero(textResourceCodeId, "textResourceCodeId");

            string textResourceCode = _queryDispatcher.Execute(new GetTextResourceCodeQuery { TextResourceCodeId = textResourceCodeId });

            CheckArgument.NotEmpty(textResourceCode, "textResourceCode");

            return new ResourceCodeDto
            {
                ResourceIdentifierCode = textResourceCode
            };
        }

        public void SaveTextResource(SaveTextResourceDto saveTextResourceDto)
        {
            // Validation cycle
            CheckArgument.NotNull(saveTextResourceDto, "SaveTextResourceDto");

            bool stringIsValidated = _queryDispatcher.Execute( new ValidateResourceStringQuery());
            
            if (stringIsValidated)
            {
                bool codeIsValidated = _queryDispatcher.Execute(new ValidateUniqueResourceCodeQuery());

                if (codeIsValidated)
                {
                    
                }

            }
            else
            {
                var stringQuery = _queryDispatcher.Execute(new GetTextResourceCodeQuery {});
                // map result to Dto
            }


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
        }


        /// <summary>
        ///  TODO -> Validate unique ResourceString
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool GetResourceString(string textResourceString)
        {
            //Return duplicate data to User(Aggregized ResourceIdentifierDto and associated TextResourceDto)
            return true; //_queryDispatcher.Execute(DuplicateResourceStringExistsQuery(dto));
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

        public bool InitializeTextResourceCache(int languageId, int clientId = 0)
        {
            // InitResourceCacheQuery

            throw new NotImplementedException();
        }
    }
}
