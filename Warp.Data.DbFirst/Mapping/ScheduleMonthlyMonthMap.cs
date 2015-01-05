using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleMonthlyMonthMap : EntityTypeConfiguration<ScheduleMonthlyMonth>
    {
        public ScheduleMonthlyMonthMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleMonthlyMonthId);

            // Properties
            // Table & Column Mappings
            ToTable("ScheduleMonthlyMonth", "Subscriptions");
            Property(t => t.ScheduleMonthlyMonthId).HasColumnName("ScheduleMonthlyMonthId");
            Property(t => t.ScheduleMonthlyId).HasColumnName("ScheduleMonthlyId");
            Property(t => t.MonthId).HasColumnName("MonthId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.Month)
                .WithMany(t => t.ScheduleMonthlyMonths)
                .HasForeignKey(d => d.MonthId);
            HasOptional(t => t.ScheduleMonthly)
                .WithMany(t => t.ScheduleMonthlyMonths)
                .HasForeignKey(d => d.ScheduleMonthlyId);

        }
    }
}
