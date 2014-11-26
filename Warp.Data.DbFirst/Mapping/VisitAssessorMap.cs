using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitAssessorMap : EntityTypeConfiguration<VisitAssessor>
    {
        public VisitAssessorMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitAssessorId);

            // Properties
            this.Property(t => t.VisitAssessorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RemovalNotes)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("VisitAssessor");
            this.Property(t => t.VisitAssessorId).HasColumnName("VisitAssessorID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.RemovedByAdminId).HasColumnName("RemovedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.PreviewedQuestionnaire).HasColumnName("PreviewedQuestionnaire");
            this.Property(t => t.RemovalReasonId).HasColumnName("RemovalReasonID");
            this.Property(t => t.RemovalNotes).HasColumnName("RemovalNotes");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.VisitAssessors)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.RemovalReason)
                .WithMany(t => t.VisitAssessors)
                .HasForeignKey(d => d.RemovalReasonId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitAssessors)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
