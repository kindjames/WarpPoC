using System;

namespace Warp.Data.DbFirst.Entities
{
    public class Error
    {
        public Guid ErrorId { get; set; }
        public int? CauseBy { get; set; }
        public string Url { get; set; }
        public string Exception { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
    }
}