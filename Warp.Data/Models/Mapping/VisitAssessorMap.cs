using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class VisitAssessorMap : EntityTypeConfiguration<VisitAssessor>
    {
        public VisitAssessorMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitAssessorID);

            // Properties
            this.Property(t => t.VisitAssessorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RemovalNotes)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("VisitAssessor");
            this.Property(t => t.VisitAssessorID).HasColumnName("VisitAssessorID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            this.Property(t => t.RemovedByAdminID).HasColumnName("RemovedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.PreviewedQuestionnaire).HasColumnName("PreviewedQuestionnaire");
            this.Property(t => t.RemovalReasonID).HasColumnName("RemovalReasonID");
            this.Property(t => t.RemovalNotes).HasColumnName("RemovalNotes");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.VisitAssessors)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.RemovalReason)
                .WithMany(t => t.VisitAssessors)
                .HasForeignKey(d => d.RemovalReasonID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitAssessors)
                .HasForeignKey(d => d.VisitID);

        }
    }
}
