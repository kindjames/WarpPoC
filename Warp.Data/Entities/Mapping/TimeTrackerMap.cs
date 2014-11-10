using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class TimeTrackerMap : EntityTypeConfiguration<TimeTracker>
    {
        public TimeTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.TimeTrackerID);

            // Properties
            this.Property(t => t.TimeTrackerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TimeTracker");
            this.Property(t => t.TimeTrackerID).HasColumnName("TimeTrackerID");
            this.Property(t => t.AdminID).HasColumnName("AdminID");
            this.Property(t => t.TimeTrackerTypeID).HasColumnName("TimeTrackerTypeID");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.TimeTrackerType)
                .WithMany(t => t.TimeTrackers)
                .HasForeignKey(d => d.TimeTrackerTypeID);

        }
    }
}
