using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class TourStepPlacementMap : EntityTypeConfiguration<TourStepPlacement>
    {
        public TourStepPlacementMap()
        {
            // Primary Key
            this.HasKey(t => t.TourStepPlacementId);

            // Properties
            this.Property(t => t.Placement)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("TourStepPlacement", "Help");
            this.Property(t => t.TourStepPlacementId).HasColumnName("TourStepPlacementID");
            this.Property(t => t.Placement).HasColumnName("Placement");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
