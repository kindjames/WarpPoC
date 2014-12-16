using System;
using Warp.Core.Services.Dtos.Users;
using Warp.Core.Services.UserService;

namespace Warp.Services
{
    public sealed class UserService : IUserService
    {
        public int GetDefaultLanguageIdForUser(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDto GetUser(int accountManagerId)
        {
            throw new NotImplementedException();
        }
    }
}