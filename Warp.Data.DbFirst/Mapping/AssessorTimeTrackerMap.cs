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
            HasKey(t => t.AssessorTimeTrackerId);

            // Properties
            Property(t => t.AssessorTimeTrackerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AssessorTimeTracker");
            Property(t => t.AssessorTimeTrackerId).HasColumnName("AssessorTimeTrackerID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.TimeTrackerId).HasColumnName("TimeTrackerID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorTimeTrackers)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.TimeTracker)
                .WithMany(t => t.AssessorTimeTrackers)
                .HasForeignKey(d => d.TimeTrackerId);

        }
    }
}
