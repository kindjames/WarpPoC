using System;

namespace Warp.Data.DbFirst.Entities
{
    public class Login
    {
        public int LoginId { get; set; }
        public int? UserId { get; set; }
        public bool Success { get; set; }
        public string IP { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
    }
}