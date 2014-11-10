using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ResultCommentMap : EntityTypeConfiguration<ResultComment>
    {
        public ResultCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.ResultCommentID);

            // Properties
            this.Property(t => t.ResultCommentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssessorComments)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.AdminComments)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ResultComment");
            this.Property(t => t.ResultCommentID).HasColumnName("ResultCommentID");
            this.Property(t => t.AssessmentID).HasColumnName("AssessmentID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.AssessorComments).HasColumnName("AssessorComments");
            this.Property(t => t.AdminID).HasColumnName("AdminID");
            this.Property(t => t.AdminComments).HasColumnName("AdminComments");
            this.Property(t => t.DateCompleted).HasColumnName("DateCompleted");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessment)
                .WithMany(t => t.ResultComments)
                .HasForeignKey(d => d.AssessmentID);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.ResultComments)
                .HasForeignKey(d => d.AssessorID);

        }
    }
}
