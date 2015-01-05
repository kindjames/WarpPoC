using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TourStepMap : EntityTypeConfiguration<TourStep>
    {
        public TourStepMap()
        {
            // Primary Key
            HasKey(t => t.TourStepId);

            // Properties
            Property(t => t.ElementId)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.StepTitle)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.StepText)
                .IsRequired();

            // Table & Column Mappings
            ToTable("TourStep", "Help");
            Property(t => t.TourStepId).HasColumnName("TourStepID");
            Property(t => t.TourId).HasColumnName("TourID");
            Property(t => t.ElementId).HasColumnName("ElementID");
            Property(t => t.StepNumber).HasColumnName("StepNumber");
            Property(t => t.StepTitle).HasColumnName("StepTitle");
            Property(t => t.StepText).HasColumnName("StepText");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.TourStepPlacementId).HasColumnName("TourStepPlacementId");

            // Relationships
            HasRequired(t => t.Tour)
                .WithMany(t => t.TourSteps)
                .HasForeignKey(d => d.TourId);
            HasOptional(t => t.TourStepPlacement)
                .WithMany(t => t.TourSteps)
                .HasForeignKey(d => d.TourStepPlacementId);

        }
    }
}
