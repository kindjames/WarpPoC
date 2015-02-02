using System;
using System.Collections.Generic;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.AutoMapper;
using hGem.Core.Services.Dtos.Users;
using hGem.Core.Services.UserService;
using hGem.Data.Entities;
using hGem.Data.Queries.General;

namespace hGem.Services
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