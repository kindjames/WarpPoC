using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PersonTimeTrackerMap : EntityTypeConfiguration<PersonTimeTracker>
    {
        public PersonTimeTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonTimeTrackerID);

            // Properties
            this.Property(t => t.PersonTimeTrackerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PersonTimeTracker");
            this.Property(t => t.PersonTimeTrackerID).HasColumnName("PersonTimeTrackerID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.TimeTrackerID).HasColumnName("TimeTrackerID");

            // Relationships
            this.HasRequired(t => t.TimeTracker)
                .WithMany(t => t.PersonTimeTrackers)
                .HasForeignKey(d => d.TimeTrackerID);

        }
    }
}
