using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class VisitTimeTrackerMap : EntityTypeConfiguration<VisitTimeTracker>
    {
        public VisitTimeTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitTimeTrackerID);

            // Properties
            this.Property(t => t.VisitTimeTrackerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitTimeTracker");
            this.Property(t => t.VisitTimeTrackerID).HasColumnName("VisitTimeTrackerID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.TimeTrackerID).HasColumnName("TimeTrackerID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.TimeTracker)
                .WithMany(t => t.VisitTimeTrackers)
                .HasForeignKey(d => d.TimeTrackerID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitTimeTrackers)
                .HasForeignKey(d => d.VisitID);

        }
    }
}
