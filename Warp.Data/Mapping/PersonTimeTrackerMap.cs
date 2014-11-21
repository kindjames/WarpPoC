using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class PersonTimeTrackerMap : EntityTypeConfiguration<PersonTimeTracker>
    {
        public PersonTimeTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonTimeTrackerId);

            // Properties
            this.Property(t => t.PersonTimeTrackerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PersonTimeTracker");
            this.Property(t => t.PersonTimeTrackerId).HasColumnName("PersonTimeTrackerID");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
            this.Property(t => t.TimeTrackerId).HasColumnName("TimeTrackerID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.TimeTracker)
                .WithMany(t => t.PersonTimeTrackers)
                .HasForeignKey(d => d.TimeTrackerId);

        }
    }
}
