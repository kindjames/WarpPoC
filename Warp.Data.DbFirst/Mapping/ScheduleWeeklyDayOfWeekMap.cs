using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleWeeklyDayOfWeekMap : EntityTypeConfiguration<ScheduleWeeklyDayOfWeek>
    {
        public ScheduleWeeklyDayOfWeekMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleWeeklyDayOfWeekId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ScheduleWeeklyDayOfWeek", "Subscriptions");
            this.Property(t => t.ScheduleWeeklyDayOfWeekId).HasColumnName("ScheduleWeeklyDayOfWeekId");
            this.Property(t => t.ScheduleWeeklyId).HasColumnName("ScheduleWeeklyId");
            this.Property(t => t.DayOfWeekId).HasColumnName("DayOfWeekId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.DayOfWeek)
                .WithMany(t => t.ScheduleWeeklyDayOfWeeks)
                .HasForeignKey(d => d.DayOfWeekId);
            this.HasOptional(t => t.ScheduleWeekly)
                .WithMany(t => t.ScheduleWeeklyDayOfWeeks)
                .HasForeignKey(d => d.ScheduleWeeklyId);

        }
    }
}
