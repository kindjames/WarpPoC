using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Warp.Core.Authentication;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Infrastructure.General;
using Warp.Core.Infrastructure.Util;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Identity
{
    public class ApplicationUserStore : IUserStore<ApplicationUser, Guid>, IUserPasswordStore<ApplicationUser, Guid>, IUserRoleStore<ApplicationUser, Guid>, IUserSecurityStampStore<ApplicationUser, Guid>, IUserEmailStore<ApplicationUser, Guid>
    //, IUserLockoutStore<ApplicationUser, int>
    {
        private IAuthenticationDbContext _dbContext;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IApplicationConfig _applicationConfig;
        private bool _disposed;

        public bool ShouldDisposeSession { get; set; }

        public ApplicationUserStore(IAuthenticationDbContext dbContext, IDateTimeProvider dateTimeProvider, IApplicationConfig applicationConfig)
        {
            _dbContext = dbContext;
            _dateTimeProvider = dateTimeProvider;
            _applicationConfig = applicationConfig;

            ShouldDisposeSession = true;
        }

        public Task CreateAsync(ApplicationUser appUser)
        {
            return Task.Run(() =>
            {
                ThrowIfDisposed();

                var user = ToUser(appUser);

                user.DateCreated = _dateTimeProvider.UtcNow();
                user.DateValidFrom = _dateTimeProvider.UtcNow();
                user.DateValidTo = _dateTimeProvider.UtcNow();
                
                try
                {
                    _dbContext.Users.Add(user);

                    _dbContext.SaveChanges();

                    appUser.Id = user.Id;
                }
                catch (DbEntityValidationException e)
                {
                    var a = e.EntityValidationErrors;
                    throw;
                }
            });
        }

        public async Task UpdateAsync(ApplicationUser appUser)
        {
            ThrowIfDisposed();

            var user = await GetUserInternal(appUser.Id);

            user.Email = appUser.Email;
            user.Forename = appUser.FirstName;
            user.Surname = appUser.LastName;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(ApplicationUser appUser)
        {
            ThrowIfDisposed();
            
            var user = await GetUserInternal(appUser.Id);

            _dbContext.Users.Remove(user);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<ApplicationUser> FindByIdAsync(Guid userId)
        {
            ThrowIfDisposed();

            var user = await GetUserInternal(userId);

            return ToApplicationUser(user);
        }

        public async Task<ApplicationUser> FindByNameAsync(string userName)
        {
            ThrowIfDisposed();

            Guid userId;

            if (Guid.TryParse(userName, out userId))
            {
                var user = await GetUserInternal(userId);

                return ToApplicationUser(user);
            }

            return await Task.Run(() => _dbContext.Users
                .Where(u => u.Email == userName)
                .Select(ToApplicationUser)
                .SingleOrDefault());
        }

        public Task SetPasswordHashAsync(ApplicationUser appUser, string passwordHash)
        {
            ThrowIfDisposed();

            appUser.PasswordHash = passwordHash;

            return Task.FromResult(0);
        }

        public Task<string> GetPasswordHashAsync(ApplicationUser appUser)
        {
            ThrowIfDisposed();

            return Task.FromResult(appUser.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(ApplicationUser appUser)
        {
            ThrowIfDisposed();

            return Task.FromResult(!String.IsNullOrWhiteSpace(appUser.PasswordHash));
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private ApplicationUser ToApplicationUser(User user)
        {
            return new ApplicationUser
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.Forename,
                LastName = user.Surname,
                PasswordHash = user.PasswordHash,
                CustomerId = user.Customer.Id
            };
        }

        private User ToUser(ApplicationUser appUser)
        {
            return new User
            {
                Id = appUser.Id,
                Email = appUser.Email,
                Forename = appUser.FirstName,
                Surname = appUser.LastName,
                PasswordHash = appUser.PasswordHash,
                Customer = new Customer { Id = appUser.CustomerId }
            };
        }

        protected async Task<User> GetUserInternal(Guid userId)
        {
            var user = await _dbContext.Users
                .SingleOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new InvalidOperationException(
                    "User not found for Id " + userId + ".");
            }

            return user;
        }

        private void Dispose(bool disposing)
        {
            if (disposing && _dbContext != null && ShouldDisposeSession)
            {
                //_dbContext.Dispose();
            }

            _disposed = true;
            _dbContext = null;
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }

        public async Task AddToRoleAsync(ApplicationUser appUser, string roleName)
        {
            throw new NotImplementedException();
            //var user = await _dbContext.Users
            //    .SingleAsync(u => u.UserId == appUser.Id);

            //var roleEntity = await _dbContext.Roles
            //    .SingleOrDefaultAsync(r => r.Name.ToUpper() == roleName.ToUpper());

            //if (roleEntity == null)
            //{
            //    throw new InvalidOperationException(String.Format("Role '{0}' not found.", roleName));
            //}

            //roleEntity.Users.Add(user);

            //await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveFromRoleAsync(ApplicationUser appUser, string roleName)
        {
            throw new NotImplementedException();
            //var user = await _dbContext.Users
            //    .SingleAsync(u => u.UserId == appUser.Id);

            //var role = await _dbContext.Roles
            //    .SingleAsync(r => r.Name == roleName);

            //user.Roles.Remove(role);

            //await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<string>> GetRolesAsync(ApplicationUser appUser)
        {
            var user = await _dbContext.Users
                .SingleAsync(u => u.Id == appUser.Id);

            var roleNames = user.RoleGroups
                .SelectMany(g => g.Roles)
                .Select(r => r.Name)
                .ToList() as IList<string>;

            return await Task.FromResult(roleNames);
        }

        public async Task<bool> IsInRoleAsync(ApplicationUser appUser, string roleName)
        {
            var user = await _dbContext.Users
                .SingleAsync(u => u.Id == appUser.Id);

            var isInRole = user.RoleGroups
                .SelectMany(g => g.Roles)
                .Any(r => r.Name == roleName);

            return await Task.FromResult(isInRole);
        }

        public Task SetSecurityStampAsync(ApplicationUser appUser, string stamp)
        {
            CheckArgument.NotNull(appUser, "appUser");

            return Task.Run(() => appUser.SecurityStamp = stamp);
        }

        public Task<string> GetSecurityStampAsync(ApplicationUser appUser)
        {
            CheckArgument.NotNull(appUser, "appUser");

            return Task.FromResult(Guid.NewGuid().ToString());
        }

        //public Task<DateTimeOffset> GetLockoutEndDateAsync(ApplicationUser user)
        //{
        //    //return Task.FromResult(user.LockoutEndDate);
        //    throw new NotImplementedException();
        //}

        //public Task SetLockoutEndDateAsync(ApplicationUser user, DateTimeOffset lockoutEnd)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> IncrementAccessFailedCountAsync(ApplicationUser user)
        //{
        //    user.AccessFailedCount += 1;
        //}

        //public Task ResetAccessFailedCountAsync(ApplicationUser user)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> GetAccessFailedCountAsync(ApplicationUser user)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> GetLockoutEnabledAsync(ApplicationUser user)
        //{
        //    return Task.FromResult(_applicationConfig.IsLockoutEnabled);
        //}

        //public Task SetLockoutEnabledAsync(ApplicationUser user, bool enabled)
        //{
        //    throw new NotImplementedException();
        //}
        public Task SetEmailAsync(ApplicationUser user, string email)
        {
            return Task.Run(() => user.Email = email);
        }

        public Task<string> GetEmailAsync(ApplicationUser user)
        {
            return Task.FromResult(user.Email);
        }

        public Task<bool> GetEmailConfirmedAsync(ApplicationUser user)
        {
            return Task.FromResult(true);
        }

        public Task SetEmailConfirmedAsync(ApplicationUser user, bool confirmed)
        {
            return Task.FromResult(0);
        }

        public async Task<ApplicationUser> FindByEmailAsync(string email)
        {
            var user = await _dbContext.Users
                .SingleOrDefaultAsync(u => u.Email == email);

            return await Task.FromResult(ToApplicationUser(user));
        }
    }
}