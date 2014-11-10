using System;

namespace Warp.Data.Entities
{
    public partial class SubscriptionDocument
    {
        public int SubscriptionDocumentId { get; set; }
        public Nullable<int> SubscriptionId { get; set; }
        public Nullable<int> ReportId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}
