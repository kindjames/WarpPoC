using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TourUserRoleTourStepMap : EntityTypeConfiguration<TourUserRoleTourStep>
    {
        public TourUserRoleTourStepMap()
        {
            // Primary Key
            this.HasKey(t => t.TourUserRoleTourStepID);

            // Properties
            // Table & Column Mappings
            this.ToTable("TourUserRoleTourStep");
            this.Property(t => t.TourUserRoleTourStepID).HasColumnName("TourUserRoleTourStepID");
            this.Property(t => t.TourUserRoleID).HasColumnName("TourUserRoleID");
            this.Property(t => t.TourStepID).HasColumnName("TourStepID");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.TourStep)
                .WithMany(t => t.TourUserRoleTourSteps)
                .HasForeignKey(d => d.TourStepID);
            this.HasRequired(t => t.TourUserRole)
                .WithMany(t => t.TourUserRoleTourSteps)
                .HasForeignKey(d => d.TourUserRoleID);

        }
    }
}
