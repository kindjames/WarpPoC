using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TimeTrackerTypeMap : EntityTypeConfiguration<TimeTrackerType>
    {
        public TimeTrackerTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TimeTrackerTypeID);

            // Properties
            this.Property(t => t.TimeTrackerTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("TimeTrackerType");
            this.Property(t => t.TimeTrackerTypeID).HasColumnName("TimeTrackerTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
