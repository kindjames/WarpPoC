using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleQuarterlyMap : EntityTypeConfiguration<ScheduleQuarterly>
    {
        public ScheduleQuarterlyMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleQuarterlyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ScheduleQuarterly", "Subscriptions");
            this.Property(t => t.ScheduleQuarterlyId).HasColumnName("ScheduleQuarterlyId");
            this.Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            this.Property(t => t.MonthOrdinal).HasColumnName("MonthOrdinal");
            this.Property(t => t.DayNumber).HasColumnName("DayNumber");
            this.Property(t => t.DayOrdinal).HasColumnName("DayOrdinal");
            this.Property(t => t.DayOfWeekId).HasColumnName("DayOfWeekId");
            this.Property(t => t.ScheduleSubTypeId).HasColumnName("ScheduleSubTypeId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.DayOfWeek)
                .WithMany(t => t.ScheduleQuarterlies)
                .HasForeignKey(d => d.DayOfWeekId);
            this.HasOptional(t => t.Schedule)
                .WithMany(t => t.ScheduleQuarterlies)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
