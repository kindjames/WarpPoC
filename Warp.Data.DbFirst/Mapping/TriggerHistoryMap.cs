using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TriggerHistoryMap : EntityTypeConfiguration<TriggerHistory>
    {
        public TriggerHistoryMap()
        {
            // Primary Key
            HasKey(t => t.TriggerHistoryId);

            // Properties
            Property(t => t.Notes)
                .HasMaxLength(300);

            // Table & Column Mappings
            ToTable("TriggerHistory", "Subscriptions");
            Property(t => t.TriggerHistoryId).HasColumnName("TriggerHistoryId");
            Property(t => t.TriggerId).HasColumnName("TriggerId");
            Property(t => t.InstanceId).HasColumnName("InstanceId");
            Property(t => t.Triggered).HasColumnName("Triggered");
            Property(t => t.DateTriggered).HasColumnName("DateTriggered");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Trigger)
                .WithMany(t => t.TriggerHistories)
                .HasForeignKey(d => d.TriggerId);

        }
    }
}
