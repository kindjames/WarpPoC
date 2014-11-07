using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TriggerMap : EntityTypeConfiguration<Trigger>
    {
        public TriggerMap()
        {
            // Primary Key
            this.HasKey(t => t.TriggerId);

            // Properties
            this.Property(t => t.TriggerName)
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("Trigger", "Subscriptions");
            this.Property(t => t.TriggerId).HasColumnName("TriggerId");
            this.Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            this.Property(t => t.TriggerName).HasColumnName("TriggerName");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.TriggerTime).HasColumnName("TriggerTime");

            // Relationships
            this.HasOptional(t => t.Schedule)
                .WithMany(t => t.Triggers)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
