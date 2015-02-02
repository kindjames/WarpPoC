using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitTimeTrackerMap : EntityTypeConfiguration<VisitTimeTracker>
    {
        public VisitTimeTrackerMap()
        {
            // Primary Key
            HasKey(t => t.VisitTimeTrackerId);

            // Properties
            Property(t => t.VisitTimeTrackerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("VisitTimeTracker");
            Property(t => t.VisitTimeTrackerId).HasColumnName("VisitTimeTrackerID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.TimeTrackerId).HasColumnName("TimeTrackerID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.TimeTracker)
                .WithMany(t => t.VisitTimeTrackers)
                .HasForeignKey(d => d.TimeTrackerId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.VisitTimeTrackers)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
