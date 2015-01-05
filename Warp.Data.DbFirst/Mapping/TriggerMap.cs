using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TriggerMap : EntityTypeConfiguration<Trigger>
    {
        public TriggerMap()
        {
            // Primary Key
            HasKey(t => t.TriggerId);

            // Properties
            Property(t => t.TriggerName)
                .HasMaxLength(75);

            // Table & Column Mappings
            ToTable("Trigger", "Subscriptions");
            Property(t => t.TriggerId).HasColumnName("TriggerId");
            Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            Property(t => t.TriggerName).HasColumnName("TriggerName");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.TriggerTime).HasColumnName("TriggerTime");

            // Relationships
            HasOptional(t => t.Schedule)
                .WithMany(t => t.Triggers)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
