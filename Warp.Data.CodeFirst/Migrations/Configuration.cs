using System;
using Warp.Core.Infrastructure.Authentication;
using Warp.Data.Entities;
using System.Data.Entity.Migrations;

namespace Warp.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<InitializationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(InitializationContext context)
        {
            var passwordHasher = new PasswordHasher();
            var hash = passwordHasher.HashPassword("");

            context.Users.Add(new User
            {
                Forename = Guid.NewGuid().ToString(),
                Surname = Guid.NewGuid().ToString(),
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
            });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
