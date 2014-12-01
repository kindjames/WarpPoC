using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TriggerHistoryMap : EntityTypeConfiguration<TriggerHistory>
    {
        public TriggerHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.TriggerHistoryId);

            // Properties
            this.Property(t => t.Notes)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("TriggerHistory", "Subscriptions");
            this.Property(t => t.TriggerHistoryId).HasColumnName("TriggerHistoryId");
            this.Property(t => t.TriggerId).HasColumnName("TriggerId");
            this.Property(t => t.InstanceId).HasColumnName("InstanceId");
            this.Property(t => t.Triggered).HasColumnName("Triggered");
            this.Property(t => t.DateTriggered).HasColumnName("DateTriggered");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Trigger)
                .WithMany(t => t.TriggerHistories)
                .HasForeignKey(d => d.TriggerId);

        }
    }
}
