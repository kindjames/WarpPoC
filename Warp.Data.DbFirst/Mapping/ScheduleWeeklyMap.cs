using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleWeeklyMap : EntityTypeConfiguration<ScheduleWeekly>
    {
        public ScheduleWeeklyMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleWeeklyId);

            // Properties
            // Table & Column Mappings
            ToTable("ScheduleWeekly", "Subscriptions");
            Property(t => t.ScheduleWeeklyId).HasColumnName("ScheduleWeeklyId");
            Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            Property(t => t.RecurEveryXWeeks).HasColumnName("RecurEveryXWeeks");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.Schedule)
                .WithMany(t => t.ScheduleWeeklies)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
