using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleTypeMap : EntityTypeConfiguration<ScheduleType>
    {
        public ScheduleTypeMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleTypeId);

            // Properties
            Property(t => t.ScheduleTypeName)
                .IsRequired()
                .HasMaxLength(75);

            // Table & Column Mappings
            ToTable("ScheduleType", "Subscriptions");
            Property(t => t.ScheduleTypeId).HasColumnName("ScheduleTypeId");
            Property(t => t.ScheduleTypeName).HasColumnName("ScheduleTypeName");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
