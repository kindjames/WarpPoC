using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class DestinationEmail
    {
        public DestinationEmail()
        {
            this.EmailRecipients = new List<EmailRecipient>();
        }

        public int DestinationEmailId { get; set; }
        public int DestinationId { get; set; }
        public int EmailTypeId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual ICollection<EmailRecipient> EmailRecipients { get; set; }
    }
}
