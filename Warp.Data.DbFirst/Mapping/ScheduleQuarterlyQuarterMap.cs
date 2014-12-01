using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleQuarterlyQuarterMap : EntityTypeConfiguration<ScheduleQuarterlyQuarter>
    {
        public ScheduleQuarterlyQuarterMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleQuarterlyQuarterId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ScheduleQuarterlyQuarter", "Subscriptions");
            this.Property(t => t.ScheduleQuarterlyQuarterId).HasColumnName("ScheduleQuarterlyQuarterId");
            this.Property(t => t.ScheduleQuarterlyId).HasColumnName("ScheduleQuarterlyId");
            this.Property(t => t.QuarterId).HasColumnName("QuarterId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.Quarter)
                .WithMany(t => t.ScheduleQuarterlyQuarters)
                .HasForeignKey(d => d.QuarterId);
            this.HasOptional(t => t.ScheduleQuarterly)
                .WithMany(t => t.ScheduleQuarterlyQuarters)
                .HasForeignKey(d => d.ScheduleQuarterlyId);

        }
    }
}
