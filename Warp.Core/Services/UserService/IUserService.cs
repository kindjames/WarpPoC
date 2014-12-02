
namespace Warp.Core.Services.UserService
{
    public interface IUserService
    {
        int GetDefaultLanguageIdForUser(int userId);
    }
}