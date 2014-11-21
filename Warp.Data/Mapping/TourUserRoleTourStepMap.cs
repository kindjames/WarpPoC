using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class TourUserRoleTourStepMap : EntityTypeConfiguration<TourUserRoleTourStep>
    {
        public TourUserRoleTourStepMap()
        {
            // Primary Key
            this.HasKey(t => t.TourUserRoleTourStepId);

            // Properties
            // Table & Column Mappings
            this.ToTable("TourUserRoleTourStep", "Help");
            this.Property(t => t.TourUserRoleTourStepId).HasColumnName("TourUserRoleTourStepID");
            this.Property(t => t.TourUserRoleId).HasColumnName("TourUserRoleID");
            this.Property(t => t.TourStepId).HasColumnName("TourStepID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.TourStep)
                .WithMany(t => t.TourUserRoleTourSteps)
                .HasForeignKey(d => d.TourStepId);
            this.HasRequired(t => t.TourUserRole)
                .WithMany(t => t.TourUserRoleTourSteps)
                .HasForeignKey(d => d.TourUserRoleId);

        }
    }
}
