using System;
using Microsoft.AspNet.Identity;

namespace Warp.Core.Authentication
{
    public class ApplicationUser : IUser<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public int AccessFailedCount { get; set; }

        public string UserName
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}