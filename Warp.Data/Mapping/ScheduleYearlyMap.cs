using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ScheduleYearlyMap : EntityTypeConfiguration<ScheduleYearly>
    {
        public ScheduleYearlyMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleYearlyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ScheduleYearly", "Subscriptions");
            this.Property(t => t.ScheduleYearlyId).HasColumnName("ScheduleYearlyId");
            this.Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            this.Property(t => t.YearInterval).HasColumnName("YearInterval");
            this.Property(t => t.MonthId).HasColumnName("MonthId");
            this.Property(t => t.DayNumber).HasColumnName("DayNumber");
            this.Property(t => t.DayOrdinal).HasColumnName("DayOrdinal");
            this.Property(t => t.DayOfWeekId).HasColumnName("DayOfWeekId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.DayOfWeek)
                .WithMany(t => t.ScheduleYearlies)
                .HasForeignKey(d => d.DayOfWeekId);
            this.HasOptional(t => t.Month)
                .WithMany(t => t.ScheduleYearlies)
                .HasForeignKey(d => d.MonthId);
            this.HasRequired(t => t.Schedule)
                .WithMany(t => t.ScheduleYearlies)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
