using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleMap : EntityTypeConfiguration<Schedule>
    {
        public ScheduleMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleId);

            // Properties
            // Table & Column Mappings
            ToTable("Schedule", "Subscriptions");
            Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            Property(t => t.ScheduleTypeId).HasColumnName("ScheduleTypeId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ScheduleType)
                .WithMany(t => t.Schedules)
                .HasForeignKey(d => d.ScheduleTypeId);

        }
    }
}
