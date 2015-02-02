using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Destination
    {
        public Destination()
        {
            DestinationEmails = new List<DestinationEmail>();
            DestinationFileShares = new List<DestinationFileShare>();
            DestinationFTPs = new List<DestinationFTP>();
            SubscriptionDestinations = new List<SubscriptionDestination>();
            SubscriptionReportDestinations = new List<SubscriptionReportDestination>();
        }

        public int DestinationId { get; set; }
        public int? DestinationTypeId { get; set; }
        public string FileName { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DestinationType DestinationType { get; set; }
        public virtual ICollection<DestinationEmail> DestinationEmails { get; set; }
        public virtual ICollection<DestinationFileShare> DestinationFileShares { get; set; }
        public virtual ICollection<DestinationFTP> DestinationFTPs { get; set; }
        public virtual ICollection<SubscriptionDestination> SubscriptionDestinations { get; set; }
        public virtual ICollection<SubscriptionReportDestination> SubscriptionReportDestinations { get; set; }
    }
}