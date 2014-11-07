using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessorTimeTrackerMap : EntityTypeConfiguration<AssessorTimeTracker>
    {
        public AssessorTimeTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorTimeTrackerID);

            // Properties
            this.Property(t => t.AssessorTimeTrackerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorTimeTracker");
            this.Property(t => t.AssessorTimeTrackerID).HasColumnName("AssessorTimeTrackerID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.TimeTrackerID).HasColumnName("TimeTrackerID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorTimeTrackers)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.TimeTracker)
                .WithMany(t => t.AssessorTimeTrackers)
                .HasForeignKey(d => d.TimeTrackerID);

        }
    }
}
