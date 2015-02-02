using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TourUserRoleTourStepMap : EntityTypeConfiguration<TourUserRoleTourStep>
    {
        public TourUserRoleTourStepMap()
        {
            // Primary Key
            HasKey(t => t.TourUserRoleTourStepId);

            // Properties
            // Table & Column Mappings
            ToTable("TourUserRoleTourStep", "Help");
            Property(t => t.TourUserRoleTourStepId).HasColumnName("TourUserRoleTourStepID");
            Property(t => t.TourUserRoleId).HasColumnName("TourUserRoleID");
            Property(t => t.TourStepId).HasColumnName("TourStepID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.TourStep)
                .WithMany(t => t.TourUserRoleTourSteps)
                .HasForeignKey(d => d.TourStepId);
            HasRequired(t => t.TourUserRole)
                .WithMany(t => t.TourUserRoleTourSteps)
                .HasForeignKey(d => d.TourUserRoleId);

        }
    }
}
