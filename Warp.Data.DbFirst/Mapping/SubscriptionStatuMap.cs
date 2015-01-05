using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionStatusMap : EntityTypeConfiguration<SubscriptionStatus>
    {
        public SubscriptionStatusMap()
        {
            // Primary Key
            HasKey(t => t.SubscriptionStatusId);

            // Properties
            // Table & Column Mappings
            ToTable("SubscriptionStatus", "Subscriptions");
            Property(t => t.SubscriptionStatusId).HasColumnName("SubscriptionStatusId");
            Property(t => t.ValidTill).HasColumnName("ValidTill");
            Property(t => t.SubscriptionStatusTypeId).HasColumnName("SubscriptionStatusTypeId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.SubscriptionStatusType)
                .WithMany(t => t.SubscriptionStatus)
                .HasForeignKey(d => d.SubscriptionStatusTypeId);

        }
    }
}
