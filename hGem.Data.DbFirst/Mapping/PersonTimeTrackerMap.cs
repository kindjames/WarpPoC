using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonTimeTrackerMap : EntityTypeConfiguration<PersonTimeTracker>
    {
        public PersonTimeTrackerMap()
        {
            // Primary Key
            HasKey(t => t.PersonTimeTrackerId);

            // Properties
            Property(t => t.PersonTimeTrackerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("PersonTimeTracker");
            Property(t => t.PersonTimeTrackerId).HasColumnName("PersonTimeTrackerID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.TimeTrackerId).HasColumnName("TimeTrackerID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.TimeTracker)
                .WithMany(t => t.PersonTimeTrackers)
                .HasForeignKey(d => d.TimeTrackerId);

        }
    }
}
