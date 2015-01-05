using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TriggerEventMap : EntityTypeConfiguration<TriggerEvent>
    {
        public TriggerEventMap()
        {
            // Primary Key
            HasKey(t => t.TriggerEventId);

            // Properties
            // Table & Column Mappings
            ToTable("TriggerEvent", "Subscriptions");
            Property(t => t.TriggerEventId).HasColumnName("TriggerEventId");
            Property(t => t.TriggerId).HasColumnName("TriggerId");
            Property(t => t.EventId).HasColumnName("EventId");
            Property(t => t.DelayTypeId).HasColumnName("DelayTypeId");
            Property(t => t.DelayValue).HasColumnName("DelayValue");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.DelayType)
                .WithMany(t => t.TriggerEvents)
                .HasForeignKey(d => d.DelayTypeId);
            HasOptional(t => t.SubscriptionEvent)
                .WithMany(t => t.TriggerEvents)
                .HasForeignKey(d => d.EventId);
            HasOptional(t => t.Trigger)
                .WithMany(t => t.TriggerEvents)
                .HasForeignKey(d => d.TriggerId);

        }
    }
}
