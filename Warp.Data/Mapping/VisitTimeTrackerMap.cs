using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class VisitTimeTrackerMap : EntityTypeConfiguration<VisitTimeTracker>
    {
        public VisitTimeTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitTimeTrackerId);

            // Properties
            this.Property(t => t.VisitTimeTrackerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitTimeTracker");
            this.Property(t => t.VisitTimeTrackerId).HasColumnName("VisitTimeTrackerID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.TimeTrackerId).HasColumnName("TimeTrackerID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.TimeTracker)
                .WithMany(t => t.VisitTimeTrackers)
                .HasForeignKey(d => d.TimeTrackerId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitTimeTrackers)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
