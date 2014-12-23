using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleMonthlyMap : EntityTypeConfiguration<ScheduleMonthly>
    {
        public ScheduleMonthlyMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleMonthlyId);

            // Properties
            // Table & Column Mappings
            ToTable("ScheduleMonthly", "Subscriptions");
            Property(t => t.ScheduleMonthlyId).HasColumnName("ScheduleMonthlyId");
            Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            Property(t => t.DayOrdinal).HasColumnName("DayOrdinal");
            Property(t => t.DayNo).HasColumnName("DayNo");
            Property(t => t.DayOfWeekId).HasColumnName("DayOfWeekId");
            Property(t => t.MonthInterval).HasColumnName("MonthInterval");
            Property(t => t.ScheduleSubTypeId).HasColumnName("ScheduleSubTypeId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.DayOfWeek)
                .WithMany(t => t.ScheduleMonthlies)
                .HasForeignKey(d => d.DayOfWeekId);
            HasOptional(t => t.Schedule)
                .WithMany(t => t.ScheduleMonthlies)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
