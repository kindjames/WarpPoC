using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using Warp.Core.Infrastructure.Authentication;
using Warp.Data.Entities;

namespace Warp.Data.Migrations.DataSeed
{
    public class AuthenticationDataFactory : IDataFactory
    {
        public void AddDataToContext(InternalMigrationsInitializationContext context)
        {
            var x = new PasswordHasher();

            var roles = new[]
            {
                new Role { RoleId = 1, Name = "GodMode", Description = "Access all areas"},
                new Role { RoleId = 2, Name = "DeleteVisit", Description = "User can delete a visit"},
                new Role { RoleId = 3, Name = "DeleteUser", Description = "User can delete user"},
                new Role { RoleId = 4, Name = "AllocateVisit", Description = "User can allocate a visit"},
                new Role { RoleId = 5, Name = "CreateSuperUser", Description = "User can upgrade other users to super users"},
                new Role { RoleId = 6, Name = "CreateCustomer", Description = "User can create a customer"},
                new Role { RoleId = 7, Name = "DeleteCustomer", Description = "User can delete a customer"},
                new Role { RoleId = 8, Name = "ChangeImpersonation", Description = "User can change the impersonated client and manager"},
                new Role { RoleId = 9, Name = "ViewHelp", Description = "User can view the help system"},
                new Role { RoleId = 10, Name = "AddHelpArticle", Description = "User can add a help article"},
                new Role { RoleId = 11, Name = "DeleteHelpArticle", Description = "User can delete help articles"}
            };

            context.Roles.AddOrUpdate(roles);
            
            var users = new[]
            {
                new User
                {
                    UserId = 1,
                    Forename = "Test",
                    Surname = "User",
                    PasswordHash = x.HashPassword("test1"),
                    Salt = "reGucpbCPtWBgsFKfNtH",
                    Email = "test@test.com",
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
                        roles[0],
                        roles[1],
                        roles[2],
                    }
                },
                new User
                {
                    UserId = 2,
                    Forename = "Test",
                    Surname = "User 2",
                    PasswordHash = x.HashPassword("test2"),
                    Salt = "reGucpbCPtWBgsFKfNtH",
                    Email = "test2@test.com",
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
                        roles[0],
                        roles[1],
                        roles[2],
                        roles[6],
                        roles[7],
                    }
                },
                new User
                {
                    UserId = 3,
                    Forename = "Test",
                    Surname = "User 3",
                    PasswordHash = x.HashPassword("test3"),
                    Salt = "reGucpbCPtWBgsFKfNtH",
                    Email = "test3@test.com",
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
                        roles[2],
                        roles[3],
                        roles[4],
                    }
                },
            };

            context.Users.AddOrUpdate(users);
        }
    }
}