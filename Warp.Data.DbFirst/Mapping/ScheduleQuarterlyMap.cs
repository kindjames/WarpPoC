using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleQuarterlyMap : EntityTypeConfiguration<ScheduleQuarterly>
    {
        public ScheduleQuarterlyMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleQuarterlyId);

            // Properties
            // Table & Column Mappings
            ToTable("ScheduleQuarterly", "Subscriptions");
            Property(t => t.ScheduleQuarterlyId).HasColumnName("ScheduleQuarterlyId");
            Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            Property(t => t.MonthOrdinal).HasColumnName("MonthOrdinal");
            Property(t => t.DayNumber).HasColumnName("DayNumber");
            Property(t => t.DayOrdinal).HasColumnName("DayOrdinal");
            Property(t => t.DayOfWeekId).HasColumnName("DayOfWeekId");
            Property(t => t.ScheduleSubTypeId).HasColumnName("ScheduleSubTypeId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.DayOfWeek)
                .WithMany(t => t.ScheduleQuarterlies)
                .HasForeignKey(d => d.DayOfWeekId);
            HasOptional(t => t.Schedule)
                .WithMany(t => t.ScheduleQuarterlies)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
