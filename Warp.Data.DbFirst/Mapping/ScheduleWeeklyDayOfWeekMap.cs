using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleWeeklyDayOfWeekMap : EntityTypeConfiguration<ScheduleWeeklyDayOfWeek>
    {
        public ScheduleWeeklyDayOfWeekMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleWeeklyDayOfWeekId);

            // Properties
            // Table & Column Mappings
            ToTable("ScheduleWeeklyDayOfWeek", "Subscriptions");
            Property(t => t.ScheduleWeeklyDayOfWeekId).HasColumnName("ScheduleWeeklyDayOfWeekId");
            Property(t => t.ScheduleWeeklyId).HasColumnName("ScheduleWeeklyId");
            Property(t => t.DayOfWeekId).HasColumnName("DayOfWeekId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.DayOfWeek)
                .WithMany(t => t.ScheduleWeeklyDayOfWeeks)
                .HasForeignKey(d => d.DayOfWeekId);
            HasOptional(t => t.ScheduleWeekly)
                .WithMany(t => t.ScheduleWeeklyDayOfWeeks)
                .HasForeignKey(d => d.ScheduleWeeklyId);

        }
    }
}
