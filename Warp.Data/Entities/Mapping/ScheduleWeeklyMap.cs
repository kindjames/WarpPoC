using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ScheduleWeeklyMap : EntityTypeConfiguration<ScheduleWeekly>
    {
        public ScheduleWeeklyMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleWeeklyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ScheduleWeekly", "Subscriptions");
            this.Property(t => t.ScheduleWeeklyId).HasColumnName("ScheduleWeeklyId");
            this.Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            this.Property(t => t.RecurEveryXWeeks).HasColumnName("RecurEveryXWeeks");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.Schedule)
                .WithMany(t => t.ScheduleWeeklies)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
