using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SubscriptionStatuMap : EntityTypeConfiguration<SubscriptionStatu>
    {
        public SubscriptionStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.SubscriptionStatusId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubscriptionStatus", "Subscriptions");
            this.Property(t => t.SubscriptionStatusId).HasColumnName("SubscriptionStatusId");
            this.Property(t => t.ValidTill).HasColumnName("ValidTill");
            this.Property(t => t.SubscriptionStatusTypeId).HasColumnName("SubscriptionStatusTypeId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.SubscriptionStatusType)
                .WithMany(t => t.SubscriptionStatus)
                .HasForeignKey(d => d.SubscriptionStatusTypeId);

        }
    }
}
