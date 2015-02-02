using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleDailyMap : EntityTypeConfiguration<ScheduleDaily>
    {
        public ScheduleDailyMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleDailyId);

            // Properties
            // Table & Column Mappings
            ToTable("ScheduleDaily", "Subscriptions");
            Property(t => t.ScheduleDailyId).HasColumnName("ScheduleDailyId");
            Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            Property(t => t.EveryWorkingWeekday).HasColumnName("EveryWorkingWeekday");
            Property(t => t.DayAfterEveryWorkingWeekday).HasColumnName("DayAfterEveryWorkingWeekday");
            Property(t => t.Interval).HasColumnName("Interval");
            Property(t => t.ScheduleSubTypeId).HasColumnName("ScheduleSubTypeId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.Schedule)
                .WithMany(t => t.ScheduleDailies)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
