using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleYearlyMap : EntityTypeConfiguration<ScheduleYearly>
    {
        public ScheduleYearlyMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleYearlyId);

            // Properties
            // Table & Column Mappings
            ToTable("ScheduleYearly", "Subscriptions");
            Property(t => t.ScheduleYearlyId).HasColumnName("ScheduleYearlyId");
            Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            Property(t => t.YearInterval).HasColumnName("YearInterval");
            Property(t => t.MonthId).HasColumnName("MonthId");
            Property(t => t.DayNumber).HasColumnName("DayNumber");
            Property(t => t.DayOrdinal).HasColumnName("DayOrdinal");
            Property(t => t.DayOfWeekId).HasColumnName("DayOfWeekId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.DayOfWeek)
                .WithMany(t => t.ScheduleYearlies)
                .HasForeignKey(d => d.DayOfWeekId);
            HasOptional(t => t.Month)
                .WithMany(t => t.ScheduleYearlies)
                .HasForeignKey(d => d.MonthId);
            HasRequired(t => t.Schedule)
                .WithMany(t => t.ScheduleYearlies)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
