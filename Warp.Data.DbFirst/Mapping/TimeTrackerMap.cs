using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TimeTrackerMap : EntityTypeConfiguration<TimeTracker>
    {
        public TimeTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.TimeTrackerId);

            // Properties
            this.Property(t => t.TimeTrackerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TimeTracker");
            this.Property(t => t.TimeTrackerId).HasColumnName("TimeTrackerID");
            this.Property(t => t.AdminId).HasColumnName("AdminID");
            this.Property(t => t.TimeTrackerTypeId).HasColumnName("TimeTrackerTypeID");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.TimeTrackerType)
                .WithMany(t => t.TimeTrackers)
                .HasForeignKey(d => d.TimeTrackerTypeId);

        }
    }
}
