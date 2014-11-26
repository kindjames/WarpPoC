using System;
using Warp.Core.Infrastructure.Authentication;
using Warp.Data.Entities;

namespace Warp.Data.Migrations.DataSeed
{
    internal class RoleDataFactory : IDataFactory<Role>
    {
        public Role[] Build()
        {
            var x = new PasswordHasher();

            return new[]
            {
                new Role { RoleId = 1, Name = "GodMode", Description = ""},
                new Role { RoleId = 2, Name = "DeleteVisit", Description = ""},
                new Role { RoleId = 3, Name = "DeleteUser", Description = ""},
                new Role { RoleId = 4, Name = "AllocateVisit", Description = ""},
                new Role { RoleId = 5, Name = "CreateSuperUser", Description = ""},
                new Role { RoleId = 6, Name = "CreateCustomer", Description = ""},
                new Role { RoleId = 7, Name = "DeleteCustomer", Description = ""},
                new Role { RoleId = 8, Name = "ChangeImpersonation", Description = ""},
                new Role { RoleId = 9, Name = "ViewHelp", Description = ""},
                new Role { RoleId = 10, Name = "AddHelpArticle", Description = ""},
                new Role { RoleId = 11, Name = "DeleteHelpArticle", Description = ""}
            };
        }
    }
}