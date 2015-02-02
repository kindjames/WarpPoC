using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleQuarterlyQuarterMap : EntityTypeConfiguration<ScheduleQuarterlyQuarter>
    {
        public ScheduleQuarterlyQuarterMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleQuarterlyQuarterId);

            // Properties
            // Table & Column Mappings
            ToTable("ScheduleQuarterlyQuarter", "Subscriptions");
            Property(t => t.ScheduleQuarterlyQuarterId).HasColumnName("ScheduleQuarterlyQuarterId");
            Property(t => t.ScheduleQuarterlyId).HasColumnName("ScheduleQuarterlyId");
            Property(t => t.QuarterId).HasColumnName("QuarterId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.Quarter)
                .WithMany(t => t.ScheduleQuarterlyQuarters)
                .HasForeignKey(d => d.QuarterId);
            HasOptional(t => t.ScheduleQuarterly)
                .WithMany(t => t.ScheduleQuarterlyQuarters)
                .HasForeignKey(d => d.ScheduleQuarterlyId);

        }
    }
}
