using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ScheduleMonthlyMap : EntityTypeConfiguration<ScheduleMonthly>
    {
        public ScheduleMonthlyMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleMonthlyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ScheduleMonthly", "Subscriptions");
            this.Property(t => t.ScheduleMonthlyId).HasColumnName("ScheduleMonthlyId");
            this.Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            this.Property(t => t.DayOrdinal).HasColumnName("DayOrdinal");
            this.Property(t => t.DayNo).HasColumnName("DayNo");
            this.Property(t => t.DayOfWeekId).HasColumnName("DayOfWeekId");
            this.Property(t => t.MonthInterval).HasColumnName("MonthInterval");
            this.Property(t => t.ScheduleSubTypeId).HasColumnName("ScheduleSubTypeId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.DayOfWeek)
                .WithMany(t => t.ScheduleMonthlies)
                .HasForeignKey(d => d.DayOfWeekId);
            this.HasOptional(t => t.Schedule)
                .WithMany(t => t.ScheduleMonthlies)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
