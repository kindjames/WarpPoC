using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TourStepMap : EntityTypeConfiguration<TourStep>
    {
        public TourStepMap()
        {
            // Primary Key
            this.HasKey(t => t.TourStepID);

            // Properties
            this.Property(t => t.ElementID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StepTitle)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.StepText)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("TourStep", "Help");
            this.Property(t => t.TourStepID).HasColumnName("TourStepID");
            this.Property(t => t.TourID).HasColumnName("TourID");
            this.Property(t => t.ElementID).HasColumnName("ElementID");
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
                .HasForeignKey(d => d.TourID);
            this.HasOptional(t => t.TourStepPlacement)
                .WithMany(t => t.TourSteps)
                .HasForeignKey(d => d.TourStepPlacementId);

        }
    }
}
