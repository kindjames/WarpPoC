using System;
using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Util;
using Warp.Core.Services.Dtos;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Core.Services.TextResourceService;
using Warp.Core.Services.UserService;
using Warp.Data.Commands.Clients;
using Warp.Data.Commands.TextResources;
using Warp.Data.Queries.TextResources;
using Warp.Core.Services;

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

            //CheckArgument.NotEmpty(textResourceString, "textResourceString");
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

        public void SaveTextResource(SaveTextResourceDto dto)  //return IResponse<TextResourceDetailDto>
        {
            #region Validation  Cycle

            CheckArgument.NotNull(dto, "SaveTextResourceDto");

            /// Validation cycle
            /// Validate ResourceString
            var IsResourceStringUnique = _dispatcher.Execute(new CheckIsResourceStringUniqueQuery
            {
                ResourceString = dto.ResourceString,
                UserLanguageId = dto.LanguageId,
                ClientId = dto.ClientId,
                ClientOverridable = dto.ClientOverridable
            });

            /// If not unique, then return associated data
            if (!IsResourceStringUnique)
            {
                /// Return associated TextResource data
                var resourceStringAssigned = _dispatcher.Execute(new GetAssociatedTextResourceDataQuery
                {
                    ResourceString = dto.ResourceString
                });
            }


            /// Validate ResourceIdentifierCode
            bool IsResourceIdentifierCodeUnique = _dispatcher.Execute(new CheckIsResourceIdentifierCodeUniqueQuery
            {
                ResourceIdentifierCode = dto.ResourceIdentifierCode
            });

            if (!IsResourceIdentifierCodeUnique)
            {

            }
            else
            {
                
            }
            // Sweet path. ResourceIdentifierCode and ResourceString are unassigned and unique
            //if (!IsResourceStringUnique && !IsResourceIdentifierCodeUnique)
            //{
            //    var associatedData =
            //        _dispatcher.Execute<SaveTextResourceCommand>();
            //}



            
            #endregion Validation  Cycle

            #region Save Cycle
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


            #endregion Save Cycle

            //return new ServiceResponse<TextResourceDetailDto>(associatedData, false);
        }

        protected bool ValidateResourceString(SaveTextResourceDto dto)
        {
            bool result = false;

            return result;
        }

        protected bool ValidateResourceCode(SaveTextResourceDto dto)
        {
            bool result = false;

            return result;
        }

        #endregion Next

        public bool InitializeTextResourceCache(Guid languageId, Guid clientId)
        {
            // InitResourceCacheQuery

            throw new NotImplementedException();
        }
    }
}
