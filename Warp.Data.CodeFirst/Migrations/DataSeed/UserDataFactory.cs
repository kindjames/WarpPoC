using System;
using System.Collections.ObjectModel;
using Warp.Core.Infrastructure.Authentication;
using Warp.Data.Entities;

namespace Warp.Data.Migrations.DataSeed
{
    internal class UserDataFactory : IDataFactory<User>
    {
        public User[] Build()
        {
            var x = new PasswordHasher();

            return new[]
            {
                new User
                {
                    UserId = 1,
                    Forename = "Test",
                    Surname = "User",
                    PasswordHash = x.HashPassword("test1"),
                    Salt = "reGucpbCPtWBgsFKfNtH",
                    Email = "test@" + Guid.NewGuid() + ".com",
                    PasswordAnswer = Guid.NewGuid().ToString(),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    DateValidFrom = DateTime.Now,
                    DateValidTo = DateTime.Now,
                    DateLastPasswordChange = DateTime.Now,
                    DateLastLoggedIn = DateTime.Now,
                    DateOfLastActivity = DateTime.Now,
                    Roles = new Collection<Role>
                    {
                        new Role {RoleId = 2},
                        new Role {RoleId = 3},
                        new Role {RoleId = 4},
                        new Role {RoleId = 5},
                    }
                },
                new User
                {
                    UserId = 2,
                    Forename = "Test",
                    Surname = "User 2",
                    PasswordHash = x.HashPassword("test2"),
                    Salt = "reGucpbCPtWBgsFKfNtH",
                    Email = "test2@" + Guid.NewGuid() + ".com",
                    PasswordAnswer = Guid.NewGuid().ToString(),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    DateValidFrom = DateTime.Now,
                    DateValidTo = DateTime.Now,
                    DateLastPasswordChange = DateTime.Now,
                    DateLastLoggedIn = DateTime.Now,
                    DateOfLastActivity = DateTime.Now,
                    Roles = new Collection<Role>
                    {
                        new Role {RoleId = 2},
                        new Role {RoleId = 3},
                        new Role {RoleId = 4},
                        new Role {RoleId = 5},
                    }
                },
                new User
                {
                    UserId = 3,
                    Forename = "Test",
                    Surname = "User 3",
                    PasswordHash = x.HashPassword("test3"),
                    Salt = "reGucpbCPtWBgsFKfNtH",
                    Email = "test3@" + Guid.NewGuid() + ".com",
                    PasswordAnswer = Guid.NewGuid().ToString(),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    DateValidFrom = DateTime.Now,
                    DateValidTo = DateTime.Now,
                    DateLastPasswordChange = DateTime.Now,
                    DateLastLoggedIn = DateTime.Now,
                    DateOfLastActivity = DateTime.Now,
                    Roles = new Collection<Role>
                    {
                        new Role {RoleId = 2},
                        new Role {RoleId = 3},
                        new Role {RoleId = 4},
                        new Role {RoleId = 5},
                    }
                },
            };
        }
    }
}