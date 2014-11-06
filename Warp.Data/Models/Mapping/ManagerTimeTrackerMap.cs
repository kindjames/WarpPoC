using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ManagerTimeTrackerMap : EntityTypeConfiguration<ManagerTimeTracker>
    {
        public ManagerTimeTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagerTimeTrackerID);

            // Properties
            this.Property(t => t.ManagerTimeTrackerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ManagerTimeTracker");
            this.Property(t => t.ManagerTimeTrackerID).HasColumnName("ManagerTimeTrackerID");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.TimeTrackerID).HasColumnName("TimeTrackerID");

            // Relationships
            this.HasRequired(t => t.TimeTracker)
                .WithMany(t => t.ManagerTimeTrackers)
                .HasForeignKey(d => d.TimeTrackerID);

        }
    }
}
