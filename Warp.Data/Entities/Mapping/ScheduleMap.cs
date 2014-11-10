using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ScheduleMap : EntityTypeConfiguration<Schedule>
    {
        public ScheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Schedule", "Subscriptions");
            this.Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            this.Property(t => t.ScheduleTypeId).HasColumnName("ScheduleTypeId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ScheduleType)
                .WithMany(t => t.Schedules)
                .HasForeignKey(d => d.ScheduleTypeId);

        }
    }
}
