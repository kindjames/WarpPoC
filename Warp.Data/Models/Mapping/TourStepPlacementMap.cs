using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
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
            this.ToTable("TourStepPlacement");
            this.Property(t => t.TourStepPlacementId).HasColumnName("TourStepPlacementId");
            this.Property(t => t.Placement).HasColumnName("Placement");
        }
    }
}
