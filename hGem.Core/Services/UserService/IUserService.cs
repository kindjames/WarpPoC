using System.Collections.Generic;
using hGem.Core.Services.Dtos.Users;

namespace hGem.Core.Services.UserService
{
    public interface IUserService
    {
        int GetDefaultLanguageIdForUser(int userId);
        UserDto GetUser(int accountManagerId);
        IEnumerable<UserDto> GetUsers();
    }
}