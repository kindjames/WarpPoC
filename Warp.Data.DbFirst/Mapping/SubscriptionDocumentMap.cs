using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionDocumentMap : EntityTypeConfiguration<SubscriptionDocument>
    {
        public SubscriptionDocumentMap()
        {
            // Primary Key
            this.HasKey(t => t.SubscriptionDocumentId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubscriptionDocument", "Subscriptions");
            this.Property(t => t.SubscriptionDocumentId).HasColumnName("SubscriptionDocumentId");
            this.Property(t => t.SubscriptionId).HasColumnName("SubscriptionId");
            this.Property(t => t.ReportId).HasColumnName("ReportId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
