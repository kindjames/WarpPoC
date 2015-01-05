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
            HasKey(t => t.VisitAssessorId);

            // Properties
            Property(t => t.VisitAssessorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.RemovalNotes)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("VisitAssessor");
            Property(t => t.VisitAssessorId).HasColumnName("VisitAssessorID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.RemovedByAdminId).HasColumnName("RemovedByAdminID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.PreviewedQuestionnaire).HasColumnName("PreviewedQuestionnaire");
            Property(t => t.RemovalReasonId).HasColumnName("RemovalReasonID");
            Property(t => t.RemovalNotes).HasColumnName("RemovalNotes");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.VisitAssessors)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.RemovalReason)
                .WithMany(t => t.VisitAssessors)
                .HasForeignKey(d => d.RemovalReasonId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.VisitAssessors)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
