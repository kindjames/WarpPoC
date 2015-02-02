using System;
using hGem.Core.Authentication;
using hGem.Core.Infrastructure.Configuration;
using hGem.Core.Infrastructure.General;
using hGem.Data.Context;
using hGem.Data.Identity;
using Microsoft.AspNet.Identity;

namespace hGem.IoC.Factories
{
    internal sealed class UserManagerFactory
    {
        private readonly IAuthenticationDbContext _context;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IApplicationConfig _applicationConfig;

        public UserManagerFactory(IAuthenticationDbContext context, IDateTimeProvider dateTimeProvider, IPasswordHasher passwordHasher, IApplicationConfig applicationConfig)
        {
            _context = context;
            _dateTimeProvider = dateTimeProvider;
            _passwordHasher = passwordHasher;
            _applicationConfig = applicationConfig;
        }

        public UserManager<ApplicationUser, Guid> Build()
        {
            return new UserManager<ApplicationUser, Guid>(new ApplicationUserStore(_context, _dateTimeProvider, _applicationConfig))
            {
                DefaultAccountLockoutTimeSpan = _applicationConfig.DefaultAccountLockoutTimeSpan,
                MaxFailedAccessAttemptsBeforeLockout = _applicationConfig.MaxFailedAccessAttemptsBeforeLockout,
                PasswordHasher = _passwordHasher
            };
        }
    }
}