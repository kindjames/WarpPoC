using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleDailyMap : EntityTypeConfiguration<ScheduleDaily>
    {
        public ScheduleDailyMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleDailyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ScheduleDaily", "Subscriptions");
            this.Property(t => t.ScheduleDailyId).HasColumnName("ScheduleDailyId");
            this.Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            this.Property(t => t.EveryWorkingWeekday).HasColumnName("EveryWorkingWeekday");
            this.Property(t => t.DayAfterEveryWorkingWeekday).HasColumnName("DayAfterEveryWorkingWeekday");
            this.Property(t => t.Interval).HasColumnName("Interval");
            this.Property(t => t.ScheduleSubTypeId).HasColumnName("ScheduleSubTypeId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.Schedule)
                .WithMany(t => t.ScheduleDailies)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
