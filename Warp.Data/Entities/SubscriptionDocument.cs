using System;

namespace Warp.Data.Entities
{
    public class SubscriptionDocument
    {
        public int SubscriptionDocumentId { get; set; }
        public int? SubscriptionId { get; set; }
        public int? ReportId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}