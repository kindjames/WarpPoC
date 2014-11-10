using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Destination
    {
        public Destination()
        {
            this.DestinationEmails = new List<DestinationEmail>();
            this.DestinationFileShares = new List<DestinationFileShare>();
            this.DestinationFTPs = new List<DestinationFTP>();
            this.SubscriptionDestinations = new List<SubscriptionDestination>();
            this.SubscriptionReportDestinations = new List<SubscriptionReportDestination>();
        }

        public int DestinationId { get; set; }
        public Nullable<int> DestinationTypeId { get; set; }
        public string FileName { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DestinationType DestinationType { get; set; }
        public virtual ICollection<DestinationEmail> DestinationEmails { get; set; }
        public virtual ICollection<DestinationFileShare> DestinationFileShares { get; set; }
        public virtual ICollection<DestinationFTP> DestinationFTPs { get; set; }
        public virtual ICollection<SubscriptionDestination> SubscriptionDestinations { get; set; }
        public virtual ICollection<SubscriptionReportDestination> SubscriptionReportDestinations { get; set; }
    }
}
