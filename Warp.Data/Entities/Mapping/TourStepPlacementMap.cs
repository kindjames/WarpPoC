using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class TourStepPlacementMap : EntityTypeConfiguration<TourStepPlacement>
    {
        public TourStepPlacementMap()
        {
            // Primary Key
            this.HasKey(t => t.TourStepPlacementID);

            // Properties
            this.Property(t => t.Placement)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("TourStepPlacement", "Help");
            this.Property(t => t.TourStepPlacementID).HasColumnName("TourStepPlacementID");
            this.Property(t => t.Placement).HasColumnName("Placement");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
