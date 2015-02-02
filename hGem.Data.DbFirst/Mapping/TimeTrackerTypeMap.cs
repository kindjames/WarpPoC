using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TimeTrackerTypeMap : EntityTypeConfiguration<TimeTrackerType>
    {
        public TimeTrackerTypeMap()
        {
            // Primary Key
            HasKey(t => t.TimeTrackerTypeId);

            // Properties
            Property(t => t.TimeTrackerTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("TimeTrackerType");
            Property(t => t.TimeTrackerTypeId).HasColumnName("TimeTrackerTypeID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
