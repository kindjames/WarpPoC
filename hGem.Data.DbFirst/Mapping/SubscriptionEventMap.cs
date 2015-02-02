using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionEventMap : EntityTypeConfiguration<SubscriptionEvent>
    {
        public SubscriptionEventMap()
        {
            // Primary Key
            HasKey(t => t.SubscriptionEventId);

            // Properties
            Property(t => t.EventName)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("SubscriptionEvent", "Subscriptions");
            Property(t => t.SubscriptionEventId).HasColumnName("SubscriptionEventId");
            Property(t => t.SubscriptionEventTypeId).HasColumnName("SubscriptionEventTypeId");
            Property(t => t.EventName).HasColumnName("EventName");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.SubscriptionEventType)
                .WithMany(t => t.SubscriptionEvents)
                .HasForeignKey(d => d.SubscriptionEventTypeId);

        }
    }
}
