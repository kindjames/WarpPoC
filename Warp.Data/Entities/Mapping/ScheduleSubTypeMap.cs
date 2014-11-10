using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ScheduleSubTypeMap : EntityTypeConfiguration<ScheduleSubType>
    {
        public ScheduleSubTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleSubTypeId);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ScheduleSubType", "Subscriptions");
            this.Property(t => t.ScheduleSubTypeId).HasColumnName("ScheduleSubTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
