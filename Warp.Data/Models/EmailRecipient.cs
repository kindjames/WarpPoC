using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class EmailRecipient
    {
        public int EmailRecipientId { get; set; }
        public int DestinationEmailId { get; set; }
        public int UserUId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DestinationEmail DestinationEmail { get; set; }
    }
}
