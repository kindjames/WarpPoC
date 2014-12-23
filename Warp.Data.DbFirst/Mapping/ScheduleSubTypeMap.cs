using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleSubTypeMap : EntityTypeConfiguration<ScheduleSubType>
    {
        public ScheduleSubTypeMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleSubTypeId);

            // Properties
            Property(t => t.Description)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("ScheduleSubType", "Subscriptions");
            Property(t => t.ScheduleSubTypeId).HasColumnName("ScheduleSubTypeId");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
