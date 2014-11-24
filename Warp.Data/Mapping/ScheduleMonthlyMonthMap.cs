using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ScheduleMonthlyMonthMap : EntityTypeConfiguration<ScheduleMonthlyMonth>
    {
        public ScheduleMonthlyMonthMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleMonthlyMonthId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ScheduleMonthlyMonth", "Subscriptions");
            this.Property(t => t.ScheduleMonthlyMonthId).HasColumnName("ScheduleMonthlyMonthId");
            this.Property(t => t.ScheduleMonthlyId).HasColumnName("ScheduleMonthlyId");
            this.Property(t => t.MonthId).HasColumnName("MonthId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.Month)
                .WithMany(t => t.ScheduleMonthlyMonths)
                .HasForeignKey(d => d.MonthId);
            this.HasOptional(t => t.ScheduleMonthly)
                .WithMany(t => t.ScheduleMonthlyMonths)
                .HasForeignKey(d => d.ScheduleMonthlyId);

        }
    }
}
