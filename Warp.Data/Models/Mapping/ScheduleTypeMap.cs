using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ScheduleTypeMap : EntityTypeConfiguration<ScheduleType>
    {
        public ScheduleTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleTypeId);

            // Properties
            this.Property(t => t.ScheduleTypeName)
                .IsRequired()
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("ScheduleType", "Subscriptions");
            this.Property(t => t.ScheduleTypeId).HasColumnName("ScheduleTypeId");
            this.Property(t => t.ScheduleTypeName).HasColumnName("ScheduleTypeName");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
