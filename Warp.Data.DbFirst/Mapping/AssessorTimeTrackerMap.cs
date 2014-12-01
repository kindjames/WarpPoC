using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorTimeTrackerMap : EntityTypeConfiguration<AssessorTimeTracker>
    {
        public AssessorTimeTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorTimeTrackerId);

            // Properties
            this.Property(t => t.AssessorTimeTrackerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorTimeTracker");
            this.Property(t => t.AssessorTimeTrackerId).HasColumnName("AssessorTimeTrackerID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.TimeTrackerId).HasColumnName("TimeTrackerID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorTimeTrackers)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.TimeTracker)
                .WithMany(t => t.AssessorTimeTrackers)
                .HasForeignKey(d => d.TimeTrackerId);

        }
    }
}
