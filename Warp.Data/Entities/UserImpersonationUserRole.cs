using System;

namespace Warp.Data.Entities
{
    public class UserImpersonationUserRole
    {
        public int UserImpersonationUserRoleId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int UserId { get; set; }
        public int UserRoleId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
    }
}