using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionDocumentMap : EntityTypeConfiguration<SubscriptionDocument>
    {
        public SubscriptionDocumentMap()
        {
            // Primary Key
            HasKey(t => t.SubscriptionDocumentId);

            // Properties
            // Table & Column Mappings
            ToTable("SubscriptionDocument", "Subscriptions");
            Property(t => t.SubscriptionDocumentId).HasColumnName("SubscriptionDocumentId");
            Property(t => t.SubscriptionId).HasColumnName("SubscriptionId");
            Property(t => t.ReportId).HasColumnName("ReportId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
