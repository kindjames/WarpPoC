using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TourStepPlacementMap : EntityTypeConfiguration<TourStepPlacement>
    {
        public TourStepPlacementMap()
        {
            // Primary Key
            HasKey(t => t.TourStepPlacementId);

            // Properties
            Property(t => t.Placement)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("TourStepPlacement", "Help");
            Property(t => t.TourStepPlacementId).HasColumnName("TourStepPlacementID");
            Property(t => t.Placement).HasColumnName("Placement");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
