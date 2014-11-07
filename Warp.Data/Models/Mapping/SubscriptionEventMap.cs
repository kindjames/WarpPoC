using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SubscriptionEventMap : EntityTypeConfiguration<SubscriptionEvent>
    {
        public SubscriptionEventMap()
        {
            // Primary Key
            this.HasKey(t => t.SubscriptionEventId);

            // Properties
            this.Property(t => t.EventName)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("SubscriptionEvent", "Subscriptions");
            this.Property(t => t.SubscriptionEventId).HasColumnName("SubscriptionEventId");
            this.Property(t => t.SubscriptionEventTypeId).HasColumnName("SubscriptionEventTypeId");
            this.Property(t => t.EventName).HasColumnName("EventName");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.SubscriptionEventType)
                .WithMany(t => t.SubscriptionEvents)
                .HasForeignKey(d => d.SubscriptionEventTypeId);

        }
    }
}
