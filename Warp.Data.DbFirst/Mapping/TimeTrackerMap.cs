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
            HasKey(t => t.TimeTrackerId);

            // Properties
            Property(t => t.TimeTrackerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("TimeTracker");
            Property(t => t.TimeTrackerId).HasColumnName("TimeTrackerID");
            Property(t => t.AdminId).HasColumnName("AdminID");
            Property(t => t.TimeTrackerTypeId).HasColumnName("TimeTrackerTypeID");
            Property(t => t.StartTime).HasColumnName("StartTime");
            Property(t => t.EndTime).HasColumnName("EndTime");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.TimeTrackerType)
                .WithMany(t => t.TimeTrackers)
                .HasForeignKey(d => d.TimeTrackerTypeId);

        }
    }
}
