using Microsoft.AspNet.Identity;
using SimpleInjector;
using Warp.Core.Authentication;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Identity;
using PasswordHasher = Warp.Core.Infrastructure.Authentication.PasswordHasher;

namespace Warp.IoC.Factories
{
    internal sealed class UserManagerFactory
    {
        public UserManager<ApplicationUser, int> Build(Container c)
        {
            return new UserManager<ApplicationUser, int>(new ApplicationUserStore(c.GetInstance<IAuthenticationDbContext>(), c.GetInstance<IDateTimeProvider>()))
            {
                PasswordHasher = new PasswordHasher()
            };
        }
    }
}