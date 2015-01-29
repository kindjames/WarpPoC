using System;
using System.Collections.Generic;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Services.Dtos.Users;
using Warp.Core.Services.UserService;
using Warp.Data.Entities;
using Warp.Data.Queries.General;

namespace Warp.Services
{
    public sealed class UserService : IUserService
    {
        private readonly IDispatcher _dispatcher;
        private readonly IObjectMapper _objectMapper;

        public UserService(IDispatcher dispatcher, IObjectMapper objectMapper)
        {
            _dispatcher = dispatcher;
            _objectMapper = objectMapper;
        }

        public int GetDefaultLanguageIdForUser(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDto GetUser(int accountManagerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetUsers()
        {
            var users = _dispatcher.Execute(new GetAllEntitiesQuery<User>());

            return _objectMapper.MapToMany<UserDto>(users);
        }
    }
}