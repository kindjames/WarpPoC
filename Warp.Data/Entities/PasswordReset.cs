using System;

namespace Warp.Data.Entities
{
    public class PasswordReset
    {
        public int PasswordResetId { get; set; }
        public string Email { get; set; }
        public bool Successful { get; set; }
        public string Token { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
    }
}