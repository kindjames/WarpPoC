using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class TriggerEventMap : EntityTypeConfiguration<TriggerEvent>
    {
        public TriggerEventMap()
        {
            // Primary Key
            this.HasKey(t => t.TriggerEventId);

            // Properties
            // Table & Column Mappings
            this.ToTable("TriggerEvent", "Subscriptions");
            this.Property(t => t.TriggerEventId).HasColumnName("TriggerEventId");
            this.Property(t => t.TriggerId).HasColumnName("TriggerId");
            this.Property(t => t.EventId).HasColumnName("EventId");
            this.Property(t => t.DelayTypeId).HasColumnName("DelayTypeId");
            this.Property(t => t.DelayValue).HasColumnName("DelayValue");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.DelayType)
                .WithMany(t => t.TriggerEvents)
                .HasForeignKey(d => d.DelayTypeId);
            this.HasOptional(t => t.SubscriptionEvent)
                .WithMany(t => t.TriggerEvents)
                .HasForeignKey(d => d.EventId);
            this.HasOptional(t => t.Trigger)
                .WithMany(t => t.TriggerEvents)
                .HasForeignKey(d => d.TriggerId);

        }
    }
}
