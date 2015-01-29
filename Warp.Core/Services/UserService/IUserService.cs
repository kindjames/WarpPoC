using System.Collections.Generic;
using Warp.Core.Services.Dtos.Users;

namespace Warp.Core.Services.UserService
{
    public interface IUserService
    {
        int GetDefaultLanguageIdForUser(int userId);
        UserDto GetUser(int accountManagerId);
        IEnumerable<UserDto> GetUsers();
    }
}