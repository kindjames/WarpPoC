using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Warp.Core.Authentication;
using Warp.Core.Util;
using Warp.Data.DbFirst.Context;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Identity
{
    public class ApplicationUserStore : IUserStore<ApplicationUser, int>, IUserPasswordStore<ApplicationUser, int>, IUserRoleStore<ApplicationUser, int>, IUserSecurityStampStore<ApplicationUser, int> //, IUserPasswordStore<ApplicationUser, int>//, IUserLockoutStore<ApplicationUser, int>
    {
        private IAuthenticationDbContext _dbContext;
        private readonly IDateTimeProvider _dateTimeProvider;
        private bool _disposed;

        public bool ShouldDisposeSession { get; set; }

        public ApplicationUserStore(IAuthenticationDbContext dbContext, IDateTimeProvider dateTimeProvider)
        {
            _dbContext = dbContext;
            _dateTimeProvider = dateTimeProvider;

            ShouldDisposeSession = true;
        }

        public Task CreateAsync(ApplicationUser appUser)
        {
            return Task.Run(() =>
            {
                ThrowIfDisposed();

                var user = ToUser(appUser);

                user.Forename = Guid.NewGuid().ToString();
                user.Surname = Guid.NewGuid().ToString();
                user.Salt = "reGucpbCPtWBgsFKfNtH";
                user.Email = "test@" + Guid.NewGuid() + ".com";
                user.PasswordAnswer = Guid.NewGuid().ToString();
                user.DateCreated = DateTime.Now;
                user.DateUpdated = DateTime.Now;
                user.DateValidFrom = DateTime.Now;
                user.DateValidTo = DateTime.Now;
                user.DateLastPasswordChange = DateTime.Now;
                user.DateLastLoggedIn = DateTime.Now;
                user.DateOfLastActivity = DateTime.Now;
                //user.ProvidorName = Guid.NewGuid().ToString();
                //user.ProvidorUserKey = "0123456789";

                try
                {

                    _dbContext.Users.Add(user);

                    _dbContext.SaveChanges();

                    appUser.Id = user.UserId;
                }
                catch (DbEntityValidationException e)
                {
                    var a = e.EntityValidationErrors;
                    throw;
                }
            });
        }

        public Task UpdateAsync(ApplicationUser appUser)
        {
            ThrowIfDisposed();

            var user = ToUser(appUser);

            _dbContext.Users.Attach(user);

            _dbContext.Entry(user).State = EntityState.Modified;

            _dbContext.Configuration.ValidateOnSaveEnabled = false;

            return _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(ApplicationUser appUser)
        {
            ThrowIfDisposed();

            return Task.Run(() =>
            {
                var userToDelete = _dbContext.Users.SingleOrDefault();

                if (userToDelete != null)
                {
                    userToDelete.Active = false;

                    _dbContext.SaveChanges();
                }
            });
        }

        public Task<ApplicationUser> FindByIdAsync(int userId)
        {
            ThrowIfDisposed();

            return Task.Run(() => _dbContext.Users
                .Where(u => u.UserId == userId)
                .Select(ToApplicationUser)
                .SingleOrDefault());
        }

        public Task<ApplicationUser> FindByNameAsync(string userName)
        {
            ThrowIfDisposed();

            return Task.Run(() => _dbContext.Users
                .Where(u => u.UserName == userName)
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
            GC.SuppressFinalize((object)this);
        }

        private ApplicationUser ToApplicationUser(User user)
        {
            return new ApplicationUser
            {
                Id = user.UserId,
                Email = user.Email,
                FirstName = user.Forename,
                LastName = user.Surname,
                UserName = user.UserName,
                PasswordHash = user.PasswordHash,
            };
        }

        private User ToUser(ApplicationUser appUser)
        {
            return new User
            {
                UserId = appUser.Id,
                Email = appUser.Email,
                Forename = appUser.FirstName,
                Surname = appUser.LastName,
                UserName = appUser.UserName,
                PasswordHash = appUser.PasswordHash,
            };
        }

        private void SetUser(ApplicationUser appUser, User user)
        {
            user.UserId = appUser.Id;
            user.Email = appUser.Email;
            user.Forename = appUser.FirstName;
            user.Surname = appUser.LastName;
            user.UserName = appUser.UserName;
            user.PasswordHash = appUser.PasswordHash;
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
            var user = _dbContext.Users
                .Single(u => u.UserId == appUser.Id);

            var roleEntity = await _dbContext.Roles
                .SingleOrDefaultAsync(r => r.Name.ToUpper() == roleName.ToUpper());

            if (roleEntity == null)
            {
                throw new InvalidOperationException(String.Format("Role '{0}' not found.", roleName));
            }

            roleEntity.Users.Add(user);

            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveFromRoleAsync(ApplicationUser appUser, string roleName)
        {
            var user = _dbContext.Users
                .Single(u => u.UserId == appUser.Id);

            var role = _dbContext.Roles
                .Single(r => r.Name == roleName);

            user.Roles.Remove(role);

            await _dbContext.SaveChangesAsync();
        }

        public Task<IList<string>> GetRolesAsync(ApplicationUser appUser)
        {
            var user = _dbContext.Users
                .Single(u => u.UserId == appUser.Id);

            var roleNames = user.Roles
                .Select(r => r.Name)
                .ToList() as IList<string>;

            return Task.FromResult(roleNames);
        }

        public Task<bool> IsInRoleAsync(ApplicationUser appUser, string roleName)
        {
            var user = _dbContext.Users
                .Single(u => u.UserId == appUser.Id);

            var isInRole = user.Roles
                .Any(r => r.Name == roleName);

            return Task.FromResult(isInRole);
        }

        public Task SetSecurityStampAsync(ApplicationUser appUser, string stamp)
        {
            CheckArgument.NotNull(appUser, "appUser");

            return Task.Run(() => appUser.SecurityStamp = stamp);
        }

        public Task<string> GetSecurityStampAsync(ApplicationUser appUser)
        {
            CheckArgument.NotNull(appUser, "appUser");

            return Task.FromResult(appUser.SecurityStamp);
        }
    }
}