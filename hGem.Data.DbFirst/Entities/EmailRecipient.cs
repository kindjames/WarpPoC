using System;

namespace Warp.Data.DbFirst.Entities
{
    public class EmailRecipient
    {
        public int EmailRecipientId { get; set; }
        public int DestinationEmailId { get; set; }
        public int UserUId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DestinationEmail DestinationEmail { get; set; }
    }
}