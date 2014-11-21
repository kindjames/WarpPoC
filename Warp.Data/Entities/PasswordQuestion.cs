using System;

namespace Warp.Data.Entities
{
    public class PasswordQuestion
    {
        public int PasswordQuestionId { get; set; }
        public string Question { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
    }
}