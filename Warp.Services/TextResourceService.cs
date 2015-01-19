using System;
using Warp.Core.Cqrs;
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
                ResourceString = textResourceString
            };
        }

        public ResourceCodeDto GetResourceIdentifierCode(Guid textResourceCodeId)
        {
            CheckArgument.NotEmptyGuid(textResourceCodeId, textResourceCodeId.ToString());

            string textResourceCode = _dispatcher.Execute(new GetTextResourceCodeQuery { TextResourceCodeId = textResourceCodeId });

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

            bool stringIsValidated = _dispatcher.Execute( new ValidateResourceStringQuery());
            
            if (stringIsValidated)
            {
                bool codeIsValidated = _dispatcher.Execute(new ValidateUniqueResourceCodeQuery());

                if (codeIsValidated)
                {
                    
                }

            }
            else
            {
                var stringQuery = _dispatcher.Execute(new GetTextResourceCodeQuery {});
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
            //if (saveTextResourceDto.Id == 0)
            //{
            //    var command = _objectMapper.Map<SaveTextResourceDto, SaveTextResourceCommand>(saveTextResourceDto);

            //    _dispatcher.Execute(command);

            //    saveTextResourceDto.Id = command.Id;
            //}
            //// Update existing Resource
            //else
            //{
            //    var command = _objectMapper.Map<SaveTextResourceDto, UpdateTextResourceCommand>(saveTextResourceDto);
            //    _dispatcher.Execute(command);
            //}
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

        public bool InitializeTextResourceCache(Guid languageId, Guid clientId)
        {
            // InitResourceCacheQuery

            throw new NotImplementedException();
        }


        public ResourceCodeDto GetTextResourceCode(Guid textResourceCodeId)
        {
            throw new NotImplementedException();
        }

        public bool CheckResourceStringExists(string textResourceString)
        {
            throw new NotImplementedException();
        }
    }
}
