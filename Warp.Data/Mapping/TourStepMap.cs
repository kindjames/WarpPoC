using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class TourStepMap : EntityTypeConfiguration<TourStep>
    {
        public TourStepMap()
        {
            // Primary Key
            this.HasKey(t => t.TourStepId);

            // Properties
            this.Property(t => t.ElementId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StepTitle)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.StepText)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("TourStep", "Help");
            this.Property(t => t.TourStepId).HasColumnName("TourStepID");
            this.Property(t => t.TourId).HasColumnName("TourID");
            this.Property(t => t.ElementId).HasColumnName("ElementID");
            this.Property(t => t.StepNumber).HasColumnName("StepNumber");
            this.Property(t => t.StepTitle).HasColumnName("StepTitle");
            this.Property(t => t.StepText).HasColumnName("StepText");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.TourStepPlacementId).HasColumnName("TourStepPlacementId");

            // Relationships
            this.HasRequired(t => t.Tour)
                .WithMany(t => t.TourSteps)
                .HasForeignKey(d => d.TourId);
            this.HasOptional(t => t.TourStepPlacement)
                .WithMany(t => t.TourSteps)
                .HasForeignKey(d => d.TourStepPlacementId);

        }
    }
}
